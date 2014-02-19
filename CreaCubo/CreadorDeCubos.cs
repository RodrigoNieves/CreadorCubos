using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaCubo
{
    enum tipoFuncion {cont,min,max,avg,suma}
    class CreadorDeCubos
    {
        private String CadenaDeConexion;
        private String query;
        private String Esquema;
        private List<String> campos;
        private List<String> tipos;
        private tipoFuncion tipoF;
        private String columnaResumen;
        private int[] elegidos;
        private List<String> todoCampo;
        private List<String> todoTipo;
        public CreadorDeCubos(String CadenaDeConexion, String Esquema, List<String> campos, List<String> tipos,tipoFuncion tf,String resumen, String Q,List<String> todot,List<String> todoc)
        {
            this.CadenaDeConexion = CadenaDeConexion;
            this.Esquema = Esquema;
            this.campos = campos;
            this.tipos = tipos;
            this.tipoF = tf;
            this.columnaResumen = resumen;
            elegidos = new int[campos.Count];
            this.query = Q;
            this.todoCampo = todoc;
            this.todoTipo = todot;
        }
        public void creaTabla()
        {
            DBConnection db = new DBConnection(CadenaDeConexion);
            db.connect();

            StringBuilder cmd = new StringBuilder();
            cmd.Append(" IF OBJECT_ID('");
            cmd.Append(Esquema);
            cmd.Append(".dbo.cube', 'U') IS NOT NULL");
            cmd.Append(" DROP TABLE ");
            cmd.Append(Esquema);
            cmd.Append(".dbo.cube");
            db.ejecutaComando(cmd.ToString());

            cmd = new StringBuilder();

            cmd.Append("Create table ");
            cmd.Append(Esquema);
            cmd.Append(".dbo.cube(");
            for (int i = 0; i < campos.Count; i++)
            {
                if (i != 0)
                {
                    cmd.Append(",");
                }
                cmd.Append(campos[i]);
                cmd.Append(" ");
                cmd.Append("Text");//tipos[i]);
            }
            if (campos.Count > 0)
            {
                cmd.Append(",");
            }
            if (tipoF == tipoFuncion.cont)
            {
                cmd.Append("Total");
            }
            else
            {
                cmd.Append(columnaResumen);
            }
            
            cmd.Append(" ");
            cmd.Append("int");
            cmd.Append(")");
            String debug = cmd.ToString();
            db.ejecutaComando(cmd.ToString());

        }
        private void generaQuery()
        {
            // agrupar por los que tienen 0, los 
            DBConnection db = new DBConnection(CadenaDeConexion);
            db.connect();

            StringBuilder cmd = new StringBuilder();
            cmd.Append("IF OBJECT_ID('dbo.#temp', 'U') IS NOT NULL ");
            cmd.Append(" DROP TABLE dbo.#temp ");
            cmd.Append(" create table dbo.#temp ( ");
	        
            for(int i=0; i<todoCampo.Count;i++){
                if(i!= 0){
                    cmd.Append(",");
                }
                cmd.Append(todoCampo[i]);
                cmd.Append(" ");
                cmd.Append(todoTipo[i]);
            }
            cmd.Append(" ) ");
            cmd.Append(" Insert into dbo.#temp ");
            cmd.Append(query);


            /* generar tabla estilo lo siguiente
             * 
 IF OBJECT_ID('dbo.#temp', 'U') IS NOT NULL  DROP TABLE dbo.#temp  
 create table dbo.#temp ( usuario int,problema int,puntos int,hora bigint,primero int )  
 Insert into dbo.#temp SELECT *  FROM [Karelotitlan].[dbo].[UsuarioProblema] 
 
 select CAST( CAST(usuario AS nvarchar) as text), CAST( CAST(problema AS nvarchar) AS text), sum(primero) from
	dbo.#temp 
	group by usuario,problema

 Insert into Karelotitlan.dbo.cube
 select CAST( CAST(usuario AS nvarchar) as text), CAST( CAST(problema AS nvarchar) AS text), sum(primero) from
	dbo.#temp 
	group by usuario,problema
 
 drop table dbo.#temp 
             * 
             */

            cmd.Append(" Insert into ");
            cmd.Append(Esquema);
            cmd.Append(".dbo.cube ");

            cmd.Append("select ");

            // lista de parametreos si tiene 0 hacer CAST si no poner 0
            for (int i = 0; i < campos.Count; i++)
            {
                if (i != 0)
                {
                    cmd.Append(",");
                }
                if (elegidos[i] == 0)
                {
                    //cmd.Append(" CAST ( CAST ( ");
                    cmd.Append(campos[i]);
                    //cmd.Append(" AS nvarchar) AS text) ");
                }
                else
                {
                    cmd.Append(" '(ALL)' ");
                }
            }
            if (campos.Count > 0)
            {
                cmd.Append(",");
            }
            switch (this.tipoF)
            {
                case tipoFuncion.cont:
                    cmd.Append(" count(*) ");
                    break;
                case tipoFuncion.avg:
                    cmd.Append(" AVG(");
                    cmd.Append(columnaResumen);
                    cmd.Append(") ");
                    break;
                case tipoFuncion.max:
                    cmd.Append(" MAX(");
                    cmd.Append(columnaResumen);
                    cmd.Append(") ");
                    break;
                case tipoFuncion.min:
                    cmd.Append(" MIN(");
                    cmd.Append(columnaResumen);
                    cmd.Append(") ");
                    break;
                case tipoFuncion.suma:
                    cmd.Append(" SUM(");
                    cmd.Append(columnaResumen);
                    cmd.Append(") ");
                    break;
            }
            cmd.Append(" from dbo.#temp ");
            
            
            // lista de grupos

            int agrupados = 0;
            for (int i = 0; i < campos.Count; i++)
            {
                if (elegidos[i] == 0)
                {
                    if (agrupados > 0)
                    {
                        cmd.Append(",");
                    }
                    else { 
                        cmd.Append(" group by ");
                    }
                    cmd.Append(campos[i]);
                    agrupados++;
                }
            }

            cmd.Append(" drop table dbo.#temp ");


            String debug = cmd.ToString();
            db.ejecutaComando(cmd.ToString());
        }
        private void asigna(int p, int cont)
        {
            if (cont == 0)
            {
                generaQuery();
                return;
            }
            if (p >= campos.Count)
            {
                return;
            }
            asigna(p + 1, cont);
            elegidos[p] = 1;
            asigna(p + 1, cont - 1);
            elegidos[p] = 0;
        }
        private void creaCubexel(int c) // 0 no se agrupa ninguno N se agrupan todos
        {
            for (int i = 0; i < campos.Count;i++)
            {
                elegidos[i] = 0;
            }
            asigna(0, c);
        }
        public void creaCubexeles()
        {
            for (int i = 0; i <= campos.Count; i++)
            {
                creaCubexel(i);
            }
        }
    }
}

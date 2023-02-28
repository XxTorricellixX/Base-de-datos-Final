using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appEjemplo.accesoDatos;
namespace appEjemplo.logica
{
    internal class Persona
    {
        Datos dt=new Datos();
        //public int ingresarPersona(int id,string nom, string eCivil,string gen)
        //{
        //    int resultado;
        //    string consulta;
        //    consulta = "insert into tblPersona(perId,perNombre,perECivil,perGenero) values(" + id + ",'" + nom + "','" + eCivil + "','" + gen + "')"; 
            
        //    resultado=  dt.ejecutarDML(consulta);
        //    return resultado;
        //}
        public int ingresarEmpresa(int nit, string nom)
        {
            int resultado;
            string consulta;
            consulta = "insert into tblEmpresa(empId,empNombre) values(" + nit + ",'" + nom + "')";

            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }

        public int ingresarComputadora(int serial, string marca,int capacidad,string tipoDisco)
        {
            int resultado;
            string consulta;
            consulta = "insert into tblComputadora(compSerial,compMarca,compCapacidad,compTipoDisco) values(" + serial + ",'" + marca + "'," + capacidad + ",'" + tipoDisco + "')";

            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }

        public int ingresarReparacionEx(int nit, int serial, DateTime ingreso, DateTime egreso)
        {
            int resultado;
            string consulta;
            consulta = "insert into tblRepara(empId,compSerial,fechaIngreso,fechaEgreso) values(" + nit + "," + serial + ",to_date('"+ ingreso + "','dd-mm-yy HH24:MI:SS'),to_date('" + egreso + "','dd-mm-yy HH24:MI:SS'))";
            
            resultado = dt.ejecutarDML(consulta);


            return resultado;
        }

        public int ingresarReparacionNoEx(int nit, int serial, DateTime ingreso)
        {
            int resultado;
            string consulta;
            consulta = "insert into tblRepara(empId,compSerial,fechaIngreso,fechaEgreso) values(" + nit + "," + serial + ",to_date('" + ingreso + "','dd-mm-yy HH24:MI:SS'),null)";

            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }


        public DataSet consulta1(int nit, DateTime ingreso)
        {
            DataSet miDs = new DataSet();
            string consulta;
            consulta = "select empNombre Nombre_Empresa,tblComputadora.compSerial Número_Serial,compMarca Marca_del_PC,compCapacidad Capacidad_del_disco,fechaEgreso Fecha_de_egreso from tblComputadora  inner join(select tblEmpresa.empId, empNombre, fechaIngreso, fechaEgreso, tblRepara.compSerial from tblEmpresa inner join tblRepara on tblEmpresa.empId= tblRepara.empId) T on tblComputadora.compSerial = T.compSerial where fechaIngreso = to_date('"+ingreso+ "', 'dd-mm-yy HH24:MI:SS') and T.empId =" + nit;
            miDs = dt.ejecutarSELECT(consulta);
            return miDs;

        }

        public DataSet consulta2()
        {
            DataSet miDs = new DataSet();
            string consulta;
            consulta = "select count(compSerial) from tblComputadora where compMarca like 'Dell' ";
            miDs = dt.ejecutarSELECT(consulta);
            return miDs;

        }
    }
}

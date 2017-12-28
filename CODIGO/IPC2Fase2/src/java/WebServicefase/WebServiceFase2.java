/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package WebServicefase;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import java.sql.*;
import conexion.ConexionBD;

/**
 *
 * @author AlejandroCJC
 */
@WebService(serviceName = "WebServiceFase2")
public class WebServiceFase2 {
            ConexionBD conex = new ConexionBD();
            
            
    @WebMethod(operationName = "hello")
    public String hello(@WebParam(name = "name") String txt) {
        return "Hello " + txt + " !";
    }
    
    //metodo para crear usuario
    @WebMethod(operationName ="CrearUsuario")
    public String CrearUsuario(@WebParam(name="nickName") String nickname,@WebParam(name="contrasena") String contrasena, @WebParam(name="correo")String correo,@WebParam(name="fecha_nac") String fecha_nac){
        ConexionBD conec = new ConexionBD();
        Connection conexion = conec.getDBConection();
        int consulta =0;
        String consultal="";
        try{
            Statement query = conexion.createStatement();
                consulta = query.executeUpdate("Insert into CrearUsuario(nickname,contrasena, correo, fecha_nac"+ 
                        "Values('"+nickname+"','"+contrasena+"','"+correo+"','"+fecha_nac+"');");
                conexion.close();
                
        }catch (Exception ex){
            System.out.println("Conexion incorreccta"+ex);
        }
            return consultal;
            
    }
}

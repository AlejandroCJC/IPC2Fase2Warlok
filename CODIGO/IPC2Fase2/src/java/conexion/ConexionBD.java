package conexion;

import java.sql.*;
/**
 *
 * @author AlejandroCJC
 */
public class ConexionBD {
    public Connection getDBConection(){
        Connection conectar = null;
    try{
       Class.forName("org.mariadb.jdbc.driver");
    }catch (Exception t){
        System.out.println(t);
    }
    try{
        conectar= DriverManager.getConnection("jdbc:mariadb://localhost/warlock","root","1234");
                return conectar;
    }catch (Exception ex){
         System.out.println(ex);
    
    }
        return conectar;
            
    }
}

# JATICS2017
Proyecto de sarrollado durante el taller impartido en el JATIC'S 2017 llevado a cabo en la Universidad Tecnologica de Puerto Peñasco

CONNEXTIONSTRINGS
no se les olvide cambiar la cadena de coneccion en el archivo de configuración.


actualmetne esta asi  (PARA MYSQL):

  

    <!-- <add name="DataModel"
         connectionString="server=127.0.0.1;user id=root;password=123123;
         persistsecurityinfo=true;database=JATICS2017Final"
         providerName="MySql.Data.MySqlClient"/> -->

    <add name="DataModel"
         connectionString="server=SUZUMA-PC\SQLEXPRESS; database=JATICS2017; 
          User=sa; password=123123; MultipleActiveResultSets=true"
         providerName="System.Data.SqlClient"/>



COMANDOS PARA CREAR LA BASE DE DATOS 
En la consola de administracion de paquetes no se les olvide ejecutar el siguiente comando:

UPDATE-DATABASE




NOTA: 
si se trabajara para mysql no se les olvide agregar la linea para que no marque error mysql

SetSqlGenerator("MySql.Data.MySqlClient",
                new MySql.Data.Entity.MySqlMigrationSqlGenerator());  

                
                
                
          


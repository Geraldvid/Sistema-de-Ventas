using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocios
{
    public class Operaciones
    {


        //declarar listas
        List<Cliente> listaCliente = new List<Cliente>();
        List<Proveedor> listaProveedor = new List<Proveedor>();
        List<Articulo> listaArticulo = new List<Articulo>();
        List<Categoria> listaCategoria = new List<Categoria>();
        List<Usuarios> listaUsuario = new List<Usuarios>();
        List<Ingreso> listaIngreso = new List<Ingreso>();
        List<Detalle_ingreso> listaDetalle = new List<Detalle_ingreso>();

        List<Venta> listaVenta = new List<Venta>();
        List<Detalle_venta> listaDetalle_venta = new List<Detalle_venta>();


        //----------------------------------------------------------------------------------CLIENTE-------------------------------------------------------------------------------------------

        //modificador de acceso
        public void agregarCliente(Cliente cli)
        {//instanciar lista para almacenar datos 
            listaCliente.Add(cli);

            //instanciar a la cadena de conexion 
            Conexion.Conectar();

            string insertar = "insert into persona (id_persona, tipo_persona, nombre, tipo_documento, num_documento, direccion, telefono, email) values (@vid, @vtp, @vnom, @vtd, @vdoc, @vdir, @vtel, @vemail)";

            SqlCommand guardar = new SqlCommand(insertar, Conexion.Conectar());

            guardar.Parameters.AddWithValue("@vid", cli.id);
            guardar.Parameters.AddWithValue("@vtp", cli.tipo_persona);
            guardar.Parameters.AddWithValue("@vnom", cli.nombre);
            guardar.Parameters.AddWithValue("@vtd", cli.tipo_doc);
            guardar.Parameters.AddWithValue("@vdoc", cli.doc);
            guardar.Parameters.AddWithValue("@vdir", cli.dir);
            guardar.Parameters.AddWithValue("@vtel", cli.tel);
            guardar.Parameters.AddWithValue("@vemail", cli.email);


            guardar.ExecuteNonQuery();

        }

        //Metodo para retornar o mostrar datos
        public DataTable mostrarCliente()
        {
            //instanciar a la cadena de conexion

            Conexion.Conectar();

            //definir una tabla virtual que capture los valores de la BD
            DataTable dta = new DataTable();

            //preparar la instruccion de consulta SQL

            string con = "select * from persona where tipo_persona = 'Cliente'";

            SqlCommand mostrar = new SqlCommand(con, Conexion.Conectar());

            SqlDataAdapter cargar = new SqlDataAdapter(mostrar);

            cargar.Fill(dta);

            return dta;

        }

        //metodo para artualizar
        public void actualizarCliente(Cliente cli)
        {

            //instanciar a la cadena de conexion 
            Conexion.Conectar();

            string actualizar = "UPDATE persona SET id_persona = @vid, tipo_persona = @vtp, nombre = @vnom, tipo_documento = @vtd, num_documento = @vdoc, direccion = @vdir, telefono = @vtel, email = @vemail WHERE id_persona = @vid";

            SqlCommand modificar = new SqlCommand(actualizar, Conexion.Conectar());


            modificar.Parameters.AddWithValue("@vid", cli.id);
            modificar.Parameters.AddWithValue("@vtp", cli.tipo_persona);
            modificar.Parameters.AddWithValue("@vnom", cli.nombre);
            modificar.Parameters.AddWithValue("@vtd", cli.tipo_doc);
            modificar.Parameters.AddWithValue("@vdoc", cli.doc);
            modificar.Parameters.AddWithValue("@vdir", cli.dir);
            modificar.Parameters.AddWithValue("@vtel", cli.tel);
            modificar.Parameters.AddWithValue("@vemail", cli.email);


            modificar.ExecuteNonQuery();

        }
        //metodo para eliminar
        public void eliminarCliente(Cliente cli)
        {

            //instanciar a la cadena de conexion 
            Conexion.Conectar();

            //Consulta para eliminar

            string eliminar = "DELETE FROM persona WHERE num_documento = @vdoc";

            SqlCommand elimin = new SqlCommand(eliminar, Conexion.Conectar());

            elimin.Parameters.AddWithValue("@vdoc", cli.doc);

            //INSTRUccion que ejecuta para eliminar en la BD
            elimin.ExecuteNonQuery();

        }


        //METODO PARA BUSCAR PERSONA

        public DataTable BuscarCliente(Cliente cli)
        {
            SqlCommand buscar = new SqlCommand("sp_buscar_cliente", Conexion.Conectar());
            buscar.CommandType = CommandType.StoredProcedure;
            buscar.Parameters.AddWithValue("@Nombre", cli.nombre);

            //Cargar valores de bd en variable 
            SqlDataAdapter da = new SqlDataAdapter(buscar);

            //Llenar tabla con valores
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }

        //----------------------------------------------------------------------------------PROVEEDORES------------------------------------------------------------------------------------------

        //metodo para agregar proveedor
        public void agregarProveedor(Proveedor pro)
        {//instanciar lista para almacenar datos 
            listaProveedor.Add(pro);

            //instanciar a la cadena de conexion 
            Conexion.Conectar();

            string insertar = "insert into persona (id_persona, tipo_persona, nombre, tipo_documento, num_documento, direccion, telefono, email) values (@vid, @vtp, @vnom, @vtd, @vdoc, @vdir, @vtel, @vemail)";

            SqlCommand guardar = new SqlCommand(insertar, Conexion.Conectar());

            guardar.Parameters.AddWithValue("@vid", pro.id_pro);
            guardar.Parameters.AddWithValue("@vtp", pro.tipo_persona);
            guardar.Parameters.AddWithValue("@vnom", pro.nombre);
            guardar.Parameters.AddWithValue("@vtd", pro.tipo_doc);
            guardar.Parameters.AddWithValue("@vdoc", pro.doc);
            guardar.Parameters.AddWithValue("@vdir", pro.dir);
            guardar.Parameters.AddWithValue("@vtel", pro.tel);
            guardar.Parameters.AddWithValue("@vemail", pro.email);


            guardar.ExecuteNonQuery();

        }

        //Metodo para retornar o mostrar datos
        public DataTable mostrarProveedor()
        {
            //instanciar a la cadena de conexion

            Conexion.Conectar();

            //definir una tabla virtual que capture los valores de la BD
            DataTable data = new DataTable();

            //preparar la instruccion de consulta SQL

            string con = "select * from persona where tipo_persona = 'Proveedor'";

            SqlCommand mostrar = new SqlCommand(con, Conexion.Conectar());

            SqlDataAdapter cargar = new SqlDataAdapter(mostrar);

            cargar.Fill(data);

            return data;

        }

        //metodo para artualizar proveedor
        public void actualizarProveedor(Proveedor pro)
        {

            //instanciar a la cadena de conexion 
            Conexion.Conectar();

            string actualizar = "UPDATE persona SET id_persona = @vid, tipo_persona = @vtp, nombre = @vnom, tipo_documento = @vtd, num_documento = @vdoc, direccion = @vdir, telefono = @vtel, email = @vemail WHERE num_documento = @vdoc";

            SqlCommand modificar = new SqlCommand(actualizar, Conexion.Conectar());


            modificar.Parameters.AddWithValue("@vid", pro.id_pro);
            modificar.Parameters.AddWithValue("@vtp", pro.tipo_persona);
            modificar.Parameters.AddWithValue("@vnom", pro.nombre);
            modificar.Parameters.AddWithValue("@vtd", pro.tipo_doc);
            modificar.Parameters.AddWithValue("@vdoc", pro.doc);
            modificar.Parameters.AddWithValue("@vdir", pro.dir);
            modificar.Parameters.AddWithValue("@vtel", pro.tel);
            modificar.Parameters.AddWithValue("@vemail", pro.email);


            modificar.ExecuteNonQuery();
        }
        //metodo para eliminar provedoor 
        public void eliminarProveedor(Proveedor pro)
            {

                //instanciar a la cadena de conexion 
                Conexion.Conectar();

                //Consulta para eliminar

                string eliminar = "DELETE FROM persona WHERE num_documento = @vdoc";

                SqlCommand elimin = new SqlCommand(eliminar, Conexion.Conectar());

                elimin.Parameters.AddWithValue("@vcid", pro.id_pro);

                //INSTRUccion que ejecuta para eliminar en la BD
                elimin.ExecuteNonQuery();
             }

        //METODO PARA BUSCAR PERSONA

        public DataTable BuscarProveedor(Proveedor pro)
        {
            SqlCommand buscar = new SqlCommand("sp_buscar_proveedor", Conexion.Conectar());
            buscar.CommandType = CommandType.StoredProcedure;
            buscar.Parameters.AddWithValue("@Nombre", pro.nombre);

            //Cargar valores de bd en variable 
            SqlDataAdapter da = new SqlDataAdapter(buscar);

            //Llenar tabla con valores
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }

        //-------------------------------------------------------------------------------ARTÍCULOS----------------------------------------------------------------------------------------------------

        //metodo para agregar articulo
        public void agregarArticulo(Articulo art)
        {//instanciar lista para almacenar datos 
            listaArticulo.Add(art);

            //instanciar a la cadena de conexion 
            Conexion.Conectar();

            string insertar = "insert into articulo (id_articulo, id_categoria,codigo, nombre, precio_venta, stock, descripcion, imagen, estado) values (@vart, @vcat, @vcod, @vnom, @vdpv, @vst, @vdes, @vima,@ves)";

            SqlCommand guardar = new SqlCommand(insertar, Conexion.Conectar());

            guardar.Parameters.AddWithValue("@vart", art.Id_articulo);
            guardar.Parameters.AddWithValue("@vcat", art.Id_categoria);
            guardar.Parameters.AddWithValue("@vcod", art.Codigo);
            guardar.Parameters.AddWithValue("@vnom", art.Nombre);
            guardar.Parameters.AddWithValue("@vdpv", art.Precio_venta);
            guardar.Parameters.AddWithValue("@vst", art.Stock);
            guardar.Parameters.AddWithValue("@vdes", art.Descripcion);
            guardar.Parameters.AddWithValue("@vima", art.Imagen);
            guardar.Parameters.AddWithValue("@ves", art.Estado);

            guardar.ExecuteNonQuery();

        }

        //Metodo para retornar o mostrar datos
        public DataTable mostrarArticulo()
        {
            //instanciar a la cadena de conexion

            Conexion.Conectar();

            //definir una tabla virtual que capture los valores de la BD
            DataTable datar = new DataTable();

            //preparar la instruccion de consulta SQL

            string con = "select * from articulo";

            SqlCommand mostrar = new SqlCommand(con, Conexion.Conectar());

            SqlDataAdapter cargar = new SqlDataAdapter(mostrar);

            cargar.Fill(datar);

            return datar;

        }
        //metodo para actualizar articulo
        public void actualizarArticulo(Articulo art)
        {//instanciar lista para almacenar datos 
            listaArticulo.Add(art);

            //instanciar a la cadena de conexion 
            Conexion.Conectar();

            string actualizar = "UPDATE articulo SET id_articulo=@vart, id_categoria=@vcat,codigo=@vcod, nombre=@vnom, precio_venta=@vdpv, stock=@vst, descripcion=@vdes, imagen=@vima, estado=@ves WHERE id_articulo=@vart";

            SqlCommand modificar = new SqlCommand(actualizar, Conexion.Conectar());

            modificar.Parameters.AddWithValue("@vart", art.Id_articulo);
            modificar.Parameters.AddWithValue("@vcat", art.Id_categoria);
            modificar.Parameters.AddWithValue("@vcod", art.Codigo);
            modificar.Parameters.AddWithValue("@vnom", art.Nombre);
            modificar.Parameters.AddWithValue("@vdpv", art.Precio_venta);
            modificar.Parameters.AddWithValue("@vst", art.Stock);
            modificar.Parameters.AddWithValue("@vdes", art.Descripcion);
            modificar.Parameters.AddWithValue("@vima", art.Imagen);
            modificar.Parameters.AddWithValue("@ves", art.Estado);

            modificar.ExecuteNonQuery();
        }

        //metodo para eliminar articuoo
        public void eliminarArticulo(Articulo art)
        {

            //instanciar a la cadena de conexion 
            Conexion.Conectar();

            //Consulta para eliminar

            string eliminar = "DELETE FROM articulo WHERE id_articulo = @vart";

            SqlCommand elimin = new SqlCommand(eliminar, Conexion.Conectar());

            elimin.Parameters.AddWithValue("@vart", art.Id_articulo);

            //INSTRUccion que ejecuta para eliminar en la BD
            elimin.ExecuteNonQuery();
        }

        //METODO PARA BUSCAR ARTICULO

        public DataTable Buscararticulo(Articulo art)
        {
            SqlCommand buscar = new SqlCommand("sp_buscar_art", Conexion.Conectar());
            buscar.CommandType = CommandType.StoredProcedure;
            buscar.Parameters.AddWithValue("@Nombre", art.Nombre);

            //Cargar valores de bd en variable 
            SqlDataAdapter da = new SqlDataAdapter(buscar);

            //Llenar tabla con valores
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }

        //-----------------------------------------------------------------------------CATEGORIA--------------------------------------------------------------------------------------------------------------------------------------------------
        //metodo para agregar categoria
        public void agregarCategoria(Categoria cat)
        {//instanciar lista para almacenar datos 
            listaCategoria.Add(cat);

            //instanciar a la cadena de conexion 
            Conexion.Conectar();

            string insertar = "INSERT INTO categoria ( id_categoria, nombre,  descripcion,  estado) values (@vid, @vnom, @vdes, @vest)";

            SqlCommand guardar = new SqlCommand(insertar, Conexion.Conectar());

            guardar.Parameters.AddWithValue("@vid", cat.Id);
            guardar.Parameters.AddWithValue("@vnom", cat.nombre);
            guardar.Parameters.AddWithValue("@vdes", cat.descripcion);
            guardar.Parameters.AddWithValue("@vest", cat.estado);
            

            guardar.ExecuteNonQuery();
        }

        //Metodo para modificar categoria
        public void modificarCategoria(Categoria cat)
        {//instanciar lista para almacenar datos 
            listaCategoria.Add(cat);

            //instanciar a la cadena de conexion 
            Conexion.Conectar();

            string actualizar = "UPDATE categoria SET id_categoria = @vid, nombre = @vnom,  descripcion = @vdes,  estado = @vest WHERE id_categoria = @vid";

            SqlCommand modificar = new SqlCommand(actualizar, Conexion.Conectar());

            modificar.Parameters.AddWithValue("@vid", cat.Id);
            modificar.Parameters.AddWithValue("@vnom", cat.nombre);
            modificar.Parameters.AddWithValue("@vdes", cat.descripcion);
            modificar.Parameters.AddWithValue("@vest", cat.estado);


            modificar.ExecuteNonQuery();
        }

        //metodo para eliminar categoria 
        public void eliminarcategoria(Categoria cat)
        {

            //instanciar a la cadena de conexion 
            Conexion.Conectar();

            //Consulta para eliminar

            string eliminar = "DELETE FROM categoria WHERE id_categoria = @vid";

            SqlCommand elimin = new SqlCommand(eliminar, Conexion.Conectar());

            elimin.Parameters.AddWithValue("@vid", cat.Id);

            //INSTRUccion que ejecuta para eliminar en la BD
            elimin.ExecuteNonQuery();
        }

        //Metodo para retornar o mostrar datos
        public DataTable mostrarcategoria()
        {
            //instanciar a la cadena de conexion

            Conexion.Conectar();

            //definir una tabla virtual que capture los valores de la BD
            DataTable datacat = new DataTable();

            //preparar la instruccion de consulta SQL

            string con = "SELECT * FROM categoria";

            SqlCommand mostrar = new SqlCommand(con, Conexion.Conectar());

            SqlDataAdapter cargar = new SqlDataAdapter(mostrar);

            cargar.Fill(datacat);

            return datacat;

        }

        //METODO PARA BUSCAR

        public DataTable Buscarcategoria(Categoria cate)
        {
            SqlCommand buscar = new SqlCommand("sp_buscar_cat", Conexion.Conectar());
            buscar.CommandType = CommandType.StoredProcedure;
            buscar.Parameters.AddWithValue("@Nombre", cate.nombre);

            //Cargar valores de bd en variable 
            SqlDataAdapter da = new SqlDataAdapter(buscar);

            //Llenar tabla con valores
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
            //--------------------------------------------------------------------------ROLES---------------------------------------------------------------------------------------------------------------

            //metodo para mostrR ROLES 
            public DataTable mostrarRoles()
        {
            //instanciar a la cadena de conexion

            Conexion.Conectar();

            //definir una tabla virtual que capture los valores de la BD
            DataTable dtarol = new DataTable();

            //preparar la instruccion de consulta SQL

            string con = "select * from rol";

            SqlCommand mostrar = new SqlCommand(con, Conexion.Conectar());

            SqlDataAdapter cargar = new SqlDataAdapter(mostrar);

            cargar.Fill(dtarol);

            return dtarol;

        }

        //---------------------------------------------------------------------USUARIOS----------------------------------------------------------------------------------------------------------------------------

        //metodo para agregar usuario
        public void agregarusuario(Usuarios user)
        {//instanciar lista para almacenar datos 
            listaUsuario.Add(user);

            //instanciar a la cadena de conexion 
            Conexion.Conectar();

            string insertar = "insert into usuario (id_usuario, id_rol, nombre, tipo_documento, num_documento, direccion, telefono, email, clave, estado) " +
                                           "values (@vid,    @vrol,     @vnom, @vtipodoc,       @vdoc,          @vdir,    @vtel, @vemail, @vclave, @vest)";

            SqlCommand guardar = new SqlCommand(insertar, Conexion.Conectar());

            guardar.Parameters.AddWithValue("@vid", user.id);
            guardar.Parameters.AddWithValue("@vrol", user.id_rol);
            guardar.Parameters.AddWithValue("@vnom", user.nombre);
            guardar.Parameters.AddWithValue("@vtipodoc", user.t_doc);
            guardar.Parameters.AddWithValue("@vdoc", user.doc);
            guardar.Parameters.AddWithValue("@vdir", user.dir);
            guardar.Parameters.AddWithValue("@vtel", user.tel);
            guardar.Parameters.AddWithValue("@vemail", user.email);
            guardar.Parameters.AddWithValue("@vclave", user.clave);
            guardar.Parameters.AddWithValue("@vest", user.estado);

            guardar.ExecuteNonQuery();

        }

        //metodo para modificar usuario
        public void modificarusuario(Usuarios user)
        {//instanciar lista para almacenar datos 
            listaUsuario.Add(user);

            //instanciar a la cadena de conexion 
            Conexion.Conectar();

            string actualizar = "Update usuario SET id_usuario = @vid, id_rol = @vrol, nombre = @vnom , tipo_documento = @vtipodoc, num_documento = @vdoc, direccion = @vdir, telefono = @vtel, email = @vemail, clave = @vclave, estado =  @vest WHERE id_usuario = @vid";

            SqlCommand modificar = new SqlCommand(actualizar, Conexion.Conectar());

            modificar.Parameters.AddWithValue("@vid", user.id);
            modificar.Parameters.AddWithValue("@vrol", user.id_rol);
            modificar.Parameters.AddWithValue("@vnom", user.nombre);
            modificar.Parameters.AddWithValue("@vtipodoc", user.t_doc);
            modificar.Parameters.AddWithValue("@vdoc", user.doc);
            modificar.Parameters.AddWithValue("@vdir", user.dir);
            modificar.Parameters.AddWithValue("@vtel", user.tel);
            modificar.Parameters.AddWithValue("@vemail", user.email);
            modificar.Parameters.AddWithValue("@vclave", user.clave);
            modificar.Parameters.AddWithValue("@vest", user.estado);

            modificar.ExecuteNonQuery();

        }

        //metodo para eliminAR usuario
        public void eliminarUsuario(Usuarios user)
        {

            //instanciar a la cadena de conexion 
            Conexion.Conectar();

            //Consulta para eliminar

            string eliminar = "DELETE FROM usuario WHERE id_usuario = @vid";

            SqlCommand elimin = new SqlCommand(eliminar, Conexion.Conectar());

            elimin.Parameters.AddWithValue("@vid", user.id);

            //INSTRUccion que ejecuta para eliminar en la BD
            elimin.ExecuteNonQuery();
        }


        //Metodo para retornar o mostrar datos
        public DataTable mostrarusuario()
        {
            //instanciar a la cadena de conexion

            Conexion.Conectar();

            //definir una tabla virtual que capture los valores de la BD
            DataTable dta = new DataTable();

            //preparar la instruccion de consulta SQL

            string con = "select * from usuario";

            SqlCommand mostrar = new SqlCommand(con, Conexion.Conectar());

            SqlDataAdapter cargar = new SqlDataAdapter(mostrar);

            cargar.Fill(dta);

            return dta;

        }

        
        //metodo para buscar usuairo
        public DataTable BuscarUsuario(Usuarios user)
        {
            SqlCommand buscar = new SqlCommand("sp_buscar_usuario", Conexion.Conectar());
            buscar.CommandType = CommandType.StoredProcedure;
            buscar.Parameters.AddWithValue("@Nombre", user.nombre);

            //Cargar valores de bd en variable 
            SqlDataAdapter da = new SqlDataAdapter(buscar);

            //Llenar tabla con valores
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }

        //------------------------------------------------------------------------------INGRESO-----------------------------------------------------------------------------------------------------------------------------


        //metodo para agregar usuario
        public void agregaringreso(Ingreso ing)
        {//instanciar lista para almacenar datos 
            listaIngreso.Add(ing);

            //instanciar a la cadena de conexion 
            Conexion.Conectar();

            string insertar = "insert into ingreso (id_ingreso, id_proveedor, id_usuario, tipo_comprobante, serie_comprobante, num_comprobante, fecha, impuesto, total, estado) " +
                                           "values (@vid, @vid_pro, @vid_user, @vtipo_com, @vserie, @vnum, @vfecha, @vimpu, @vtotal,  @vest)";

            SqlCommand guardar = new SqlCommand(insertar, Conexion.Conectar());

            guardar.Parameters.AddWithValue("@vid", ing.id);
            guardar.Parameters.AddWithValue("@vid_pro", ing.id_proveedor);
            guardar.Parameters.AddWithValue("@vid_user", ing.id_usuario);
            guardar.Parameters.AddWithValue("@vtipo_com", ing.tipo_comprobante);
            guardar.Parameters.AddWithValue("@vserie", ing.serie_comprobante);
            guardar.Parameters.AddWithValue("@vnum", ing.num_comprobante);
            guardar.Parameters.AddWithValue("@vfecha", ing.fecha);
            guardar.Parameters.AddWithValue("@vimpu", ing.impuesto);
            guardar.Parameters.AddWithValue("@vtotal", ing.total);
            guardar.Parameters.AddWithValue("@vest", ing.estado);

            guardar.ExecuteNonQuery();

        }

        /*
        public void modificaringreso(Ingreso ing)
        {//instanciar lista para almacenar datos 
            listaIngreso.Add(ing);

            //instanciar a la cadena de conexion 
            Conexion.Conectar();

            string actualizar = "UPDATE ingreso SET id_ingreso = @vid, id_proveedor = @vid_pro, id_usuario = @vid_user, tipo_comprobante = @vtipo_com, serie_comprobante = @vserie, num_comprobante = @vnum, fecha = @vfecha, impuesto = @vimpu, total = @vtotal, estado = @vest ";

            SqlCommand modificar = new SqlCommand(actualizar, Conexion.Conectar());

            modificar.Parameters.AddWithValue("@vid", ing.id);
            modificar.Parameters.AddWithValue("@vid_pro", ing.id_proveedor);
            modificar.Parameters.AddWithValue("@vid_user", ing.id_usuario);
            modificar.Parameters.AddWithValue("@vtipo_com", ing.tipo_comprobante);
            modificar.Parameters.AddWithValue("@vserie", ing.serie_comprobante);
            modificar.Parameters.AddWithValue("@vnum", ing.num_comprobante);
            modificar.Parameters.AddWithValue("@vfecha", ing.fecha);
            modificar.Parameters.AddWithValue("@vimpu", ing.impuesto);
            modificar.Parameters.AddWithValue("@vtotal", ing.total);
            modificar.Parameters.AddWithValue("@vest", ing.estado);

            modificar.ExecuteNonQuery();

        }



        public void eliminaringreso(Ingreso ing)
        {

            //instanciar a la cadena de conexion 
            Conexion.Conectar();

            //Consulta para eliminar

            string eliminar = "DELETE FROM ingreso WHERE id_ingreso = @vid";

            SqlCommand elimin = new SqlCommand(eliminar, Conexion.Conectar());

            elimin.Parameters.AddWithValue("@vid", ing.id);

            //INSTRUccion que ejecuta para eliminar en la BD
            elimin.ExecuteNonQuery();
        }
        */

        //metodo para calcular subtotal
        public decimal calcularsubtotal(decimal precio, decimal cantidad)
        {

            return precio * cantidad;

        }
        //metodo para calcular total de impuesto
        public double total_impuesto(double subtotal)
        {
            double resultado;
            resultado = subtotal * 0.13;
            return resultado;

        }
        //metodo para calcular total
        public decimal total(decimal subtotal, decimal total_impu)
        {

            return (subtotal + total_impu );

        }


        //------------------------------------------------------------------------------ DETALLE INGRESO-----------------------------------------------------------------------------------------------------------------------------


        public void agregarDetalle(Detalle_ingreso det)
        {//instanciar lista para almacenar datos 
            listaDetalle.Add(det);

            //instanciar a la cadena de conexion 
            Conexion.Conectar();

            string insertar = "insert into detalle_ingreso (id_detalle_ingreso, id_ingreso, id_articulo, cantidad, precio) " +
                                           "values (@vid, @vid_ing, @vid_art, @vcantidad, @vprecio)";

            SqlCommand guardar = new SqlCommand(insertar, Conexion.Conectar());

            guardar.Parameters.AddWithValue("@vid", det.id_d_i);
            guardar.Parameters.AddWithValue("@vid_ing", det.id_ingreso);
            guardar.Parameters.AddWithValue("@vid_art", det.id_articulo);
            guardar.Parameters.AddWithValue("@vcantidad", det.cantidad);
            guardar.Parameters.AddWithValue("@vprecio", det.precio);

            guardar.ExecuteNonQuery();

        }

        /*
        public void modificarDetalle(Detalle_ingreso det)
        {//instanciar lista para almacenar datos 
            listaDetalle.Add(det);

            //instanciar a la cadena de conexion 
            Conexion.Conectar();

            string modificar = "UPDATE detalle_ingreso SET id_detalle_ingreso = @vid, id_ingreso = @vid_ing, id_articulo = @vid_art, cantidad = @vcantidad, precio = @vprecio WHERE id_detalle_ingreso = @vid";

            SqlCommand actualizar = new SqlCommand(modificar, Conexion.Conectar());

            actualizar.Parameters.AddWithValue("@vid", det.id_d_i);
            actualizar.Parameters.AddWithValue("@vid_ing", det.id_ingreso);
            actualizar.Parameters.AddWithValue("@vid_art", det.id_articulo);
            actualizar.Parameters.AddWithValue("@vcantidad", det.cantidad);
            actualizar.Parameters.AddWithValue("@vprecio", det.precio);

            actualizar.ExecuteNonQuery();

        }

        public void eliminardetalle(Detalle_ingreso det)
        {

            //instanciar a la cadena de conexion 
            Conexion.Conectar();

            //Consulta para eliminar

            string eliminar = "DELETE FROM detalle_ingreso WHERE id_detalle_ingreso = @vid";

            SqlCommand elimin = new SqlCommand(eliminar, Conexion.Conectar());

            elimin.Parameters.AddWithValue("@vid", det.id_d_i);

            //INSTRUccion que ejecuta para eliminar en la BD
            elimin.ExecuteNonQuery();
        }
        */

        public DataTable mostrardetalle()
        {
            //instanciar a la cadena de conexion

            Conexion.Conectar();

            //definir una tabla virtual que capture los valores de la BD
            DataTable dta = new DataTable();

            //preparar la instruccion de consulta SQL

            string con = "Select d.id_detalle_ingreso as Detalle_ingreso, i.id_ingreso as ID_Ingreso, i.id_proveedor as ID_Proveedor, i.id_usuario as ID_Usuario, i.tipo_comprobante as Tipo_comprobante, i.serie_comprobante as Serie_comprobante, i.num_comprobante as Num_comprobante, d.id_articulo as ID_Articulo, d.cantidad as Cantidad, d.precio as Precio, i.fecha as Fecha, i.impuesto as Impuesto, i.total as Total, i.estado as Estado FROM detalle_ingreso d, ingreso i WHERE i.id_ingreso = d.id_ingreso ";

            SqlCommand mostrar = new SqlCommand(con, Conexion.Conectar());

            SqlDataAdapter cargar = new SqlDataAdapter(mostrar);

            cargar.Fill(dta);

            return dta;

        }


        //metodo para buscar usuairo
        public DataTable Buscarcompra(Ingreso ing)
        {
            SqlCommand buscar = new SqlCommand("sp_buscar_comprobante", Conexion.Conectar());
            buscar.CommandType = CommandType.StoredProcedure;
            buscar.Parameters.AddWithValue("@numero", ing.num_comprobante);

            //Cargar valores de bd en variable 
            SqlDataAdapter da = new SqlDataAdapter(buscar);

            //Llenar tabla con valores
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }



        //------------------------------------------------------------------------------ VENTA-----------------------------------------------------------------------------------------------------------------------------


        //metodo para agregar usuario
        public void agregarventa(Venta ven)
        {//instanciar lista para almacenar datos 
            listaVenta.Add(ven);

            //instanciar a la cadena de conexion 
            Conexion.Conectar();

            string insertar = "insert into venta (id_venta, id_cliente, id_usuario, tipo_comprobante, serie_comprobante, num_comprobante, fecha, impuesto, total, estado) " +
                                           "values (@vid, @vid_cli, @vid_user, @vtipo_com, @vserie, @vnum, @vfecha, @vimpu, @vtotal,  @vest)";

            SqlCommand guardar = new SqlCommand(insertar, Conexion.Conectar());

            guardar.Parameters.AddWithValue("@vid", ven.id_venta);
            guardar.Parameters.AddWithValue("@vid_cli", ven.id_cliente);
            guardar.Parameters.AddWithValue("@vid_user", ven.id_usuario);
            guardar.Parameters.AddWithValue("@vtipo_com", ven.tipo_comprobante);
            guardar.Parameters.AddWithValue("@vserie", ven.serie_comprobante);
            guardar.Parameters.AddWithValue("@vnum", ven.num_comprobante);
            guardar.Parameters.AddWithValue("@vfecha", ven.fecha);
            guardar.Parameters.AddWithValue("@vimpu", ven.impuesto);
            guardar.Parameters.AddWithValue("@vtotal", ven.total);
            guardar.Parameters.AddWithValue("@vest", ven.estado);

            guardar.ExecuteNonQuery();

        }

        /*
        public void modificaringreso(Ingreso ing)
        {//instanciar lista para almacenar datos 
            listaIngreso.Add(ing);

            //instanciar a la cadena de conexion 
            Conexion.Conectar();

            string actualizar = "UPDATE ingreso SET id_ingreso = @vid, id_proveedor = @vid_pro, id_usuario = @vid_user, tipo_comprobante = @vtipo_com, serie_comprobante = @vserie, num_comprobante = @vnum, fecha = @vfecha, impuesto = @vimpu, total = @vtotal, estado = @vest ";

            SqlCommand modificar = new SqlCommand(actualizar, Conexion.Conectar());

            modificar.Parameters.AddWithValue("@vid", ing.id);
            modificar.Parameters.AddWithValue("@vid_pro", ing.id_proveedor);
            modificar.Parameters.AddWithValue("@vid_user", ing.id_usuario);
            modificar.Parameters.AddWithValue("@vtipo_com", ing.tipo_comprobante);
            modificar.Parameters.AddWithValue("@vserie", ing.serie_comprobante);
            modificar.Parameters.AddWithValue("@vnum", ing.num_comprobante);
            modificar.Parameters.AddWithValue("@vfecha", ing.fecha);
            modificar.Parameters.AddWithValue("@vimpu", ing.impuesto);
            modificar.Parameters.AddWithValue("@vtotal", ing.total);
            modificar.Parameters.AddWithValue("@vest", ing.estado);

            modificar.ExecuteNonQuery();

        }



        public void eliminaringreso(Ingreso ing)
        {

            //instanciar a la cadena de conexion 
            Conexion.Conectar();

            //Consulta para eliminar

            string eliminar = "DELETE FROM ingreso WHERE id_ingreso = @vid";

            SqlCommand elimin = new SqlCommand(eliminar, Conexion.Conectar());

            elimin.Parameters.AddWithValue("@vid", ing.id);

            //INSTRUccion que ejecuta para eliminar en la BD
            elimin.ExecuteNonQuery();
        }
        */

        //metodo para calcular subtotal
        public decimal calcularsubtotalventa(decimal precio, decimal cantidad)
        {

            return precio * cantidad;

        }
        //metodo para calcular total de impuesto
        public double total_impuesto_venta(double subtotal)
        {
            double resultado;
            resultado = subtotal  * 0.13;
            return resultado;

        }

        //metodo para calcular descuentoo
        public double total_descuento(double subtotal, double descuento)
        {
             
            return (subtotal * descuento)/100;

        }

        //metodo para calcular total
        public decimal total_venta(decimal subtotal, decimal total_impu, decimal descuento)
        {

            return ((subtotal - descuento) + total_impu);

        }



        //------------------------------------------------------------------------------DETALLE VENTA-----------------------------------------------------------------------------------------------------------------------------


        public void agregarDetalle_venta(Detalle_venta dv)
        {//instanciar lista para almacenar datos 
            listaDetalle_venta.Add(dv);

            //instanciar a la cadena de conexion 
            Conexion.Conectar();

            string insertar = "insert into detalle_venta (id_detalle_venta, id_venta, id_articulo, cantidad, precio, descuento) " +
                                           "values (@vid, @vid_ing, @vid_art, @vcantidad, @vprecio, @vdesc)";

            SqlCommand guardar = new SqlCommand(insertar, Conexion.Conectar());

            guardar.Parameters.AddWithValue("@vid", dv.id_d_v);
            guardar.Parameters.AddWithValue("@vid_ing", dv.id_venta);
            guardar.Parameters.AddWithValue("@vid_art", dv.id_articulo);
            guardar.Parameters.AddWithValue("@vcantidad", dv.cantidad);
            guardar.Parameters.AddWithValue("@vprecio", dv.precio);
            guardar.Parameters.AddWithValue("@vdesc", dv.descuento);
            guardar.ExecuteNonQuery();

        }

        /*
        public void modificarDetalle(Detalle_ingreso det)
        {//instanciar lista para almacenar datos 
            listaDetalle.Add(det);

            //instanciar a la cadena de conexion 
            Conexion.Conectar();

            string modificar = "UPDATE detalle_ingreso SET id_detalle_ingreso = @vid, id_ingreso = @vid_ing, id_articulo = @vid_art, cantidad = @vcantidad, precio = @vprecio WHERE id_detalle_ingreso = @vid";

            SqlCommand actualizar = new SqlCommand(modificar, Conexion.Conectar());

            actualizar.Parameters.AddWithValue("@vid", det.id_d_i);
            actualizar.Parameters.AddWithValue("@vid_ing", det.id_ingreso);
            actualizar.Parameters.AddWithValue("@vid_art", det.id_articulo);
            actualizar.Parameters.AddWithValue("@vcantidad", det.cantidad);
            actualizar.Parameters.AddWithValue("@vprecio", det.precio);

            actualizar.ExecuteNonQuery();

        }

        public void eliminardetalle(Detalle_ingreso det)
        {

            //instanciar a la cadena de conexion 
            Conexion.Conectar();

            //Consulta para eliminar

            string eliminar = "DELETE FROM detalle_ingreso WHERE id_detalle_ingreso = @vid";

            SqlCommand elimin = new SqlCommand(eliminar, Conexion.Conectar());

            elimin.Parameters.AddWithValue("@vid", det.id_d_i);

            //INSTRUccion que ejecuta para eliminar en la BD
            elimin.ExecuteNonQuery();
        }
        */

        public DataTable mostrardetalle_venta()
        {
            //instanciar a la cadena de conexion

            Conexion.Conectar();

            //definir una tabla virtual que capture los valores de la BD
            DataTable dta = new DataTable();

            //preparar la instruccion de consulta SQL

            string con = "Select d.id_detalle_venta as Detalle_Venta, v.id_venta as ID_Venta, v.id_cliente as ID_Cliente, v.id_usuario as ID_Usuario, v.tipo_comprobante as Tipo_comprobante, v.serie_comprobante as Serie_comprobante, v.num_comprobante as Num_comprobante, d.id_articulo as ID_Articulo, d.cantidad as Cantidad, d.precio as Precio, v.fecha as Fecha, v.impuesto as Impuesto, d.cantidad as Descuento, v.total as Total, v.estado as Estado FROM detalle_venta d, venta v WHERE d.id_venta = v.id_venta";
           
            SqlCommand mostrar = new SqlCommand(con, Conexion.Conectar());

            SqlDataAdapter cargar = new SqlDataAdapter(mostrar);

            cargar.Fill(dta);

            return dta;

        }


        //metodo para buscar usuairo
        public DataTable Buscarventa(Venta ven)
        {
            SqlCommand buscar = new SqlCommand("sp_buscar_venta", Conexion.Conectar());
            buscar.CommandType = CommandType.StoredProcedure;
            buscar.Parameters.AddWithValue("@numero", ven.num_comprobante);

            //Cargar valores de bd en variable 
            SqlDataAdapter da = new SqlDataAdapter(buscar);

            //Llenar tabla con valores
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }



    }
}

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Primera Pre-Entrega");

internal class Usuario
{
    #region Propiedades

    private int id = 0;
    private string nombre = string.Empty;
    private string apellido = string.Empty;
    private string nombreUsuario = string.Empty;
    private string contrasena = string.Empty;
    private string mail = string.Empty;

    #endregion

    #region Setters and Getters

    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string NombreUsuario { get; set; }
    public string Contrasena { get; set; }
    public string Mail { get; set; }

    #endregion

    #region Constructores

    public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contrasena, string mail)
    {
        Id = id;
        Nombre = nombre;
        Apellido = apellido;
        NombreUsuario = nombreUsuario;
        Contrasena = contrasena;
        Mail = mail;
    }

    #endregion
}

internal class Venta
{
    #region Propiedades

    private int id = 0;
    private string comentarios = string.Empty;
    private int idUsuario = 0;

    #endregion

    #region Setters and Getters

    public int Id { get; set; }
    public string Comentarios { get; set; }
    public int IdUsuario { get; set; }

    #endregion

    #region Constructores

    public Venta(int id, string comentarios, int idUsuario)
    {
        Id = id;
        Comentarios = comentarios;
        IdUsuario = idUsuario;
    }

    #endregion

}

internal class Producto
{
    #region Propiedades

    private int id = 0;
    private string descripcion = string.Empty;
    private double costo = 0;
    private double precioVenta = 0;
    private int stock = 0;
    private int idUsuario = 0;

    #endregion

    #region Setters and Getters

    public int Id { get; set; }
    public string Descripcion { get; set; }
    public double Costo { get; set; }
    public double PrecioVenta { get; set; }
    public int Stock { get; set; }
    public int IdUsuario { get; set; }

    #endregion

    #region Constructores

    public Producto(int id, string descripcion, double costo, double precioVenta, int stock, int idUsuario)
    {
        Id = id;
        Descripcion = descripcion;
        Costo = costo;
        PrecioVenta = precioVenta;
        Stock = stock;
        IdUsuario = idUsuario;
    }

    #endregion
}

internal class ProductoVendido
{
    #region Propiedades

    private int id = 0;
    private int idProducto = 0;
    private int stock = 0;
    private int idVenta = 0;

    #endregion

    #region Setters and Getters

    public int Id { get; set; }
    public int IdProducto { get; set; }
    public int Stock { get; set; }
    public int IdVenta { get; set; }

    #endregion

    #region Constructores

    public ProductoVendido(int id, int idProducto, int stock, int idVenta)
    {
        Id = id;
        IdProducto = idProducto;
        Stock = stock;
        IdVenta = idVenta;
    }

    #endregion

}
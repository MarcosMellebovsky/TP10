using System.Data.SqlClient;
using Dapper;
public static class BD
{
    private static string connectionString = @"Server=localhost;DataBase=BDSeries;Trusted_Connection=True;";

    public static Temporadas InfoTemporada(int idTemporada)
    {
        Temporadas InfoT = new Temporadas();
        string SQL = "SELECT * FROM Temporadas WHERE IdTemporada = @idTem";
        using (SqlConnection db = new SqlConnection(connectionString))
        {
            InfoT = db.QueryFirstOrDefault<Temporadas>(SQL, new{idTem = idTemporada});
        }
        return InfoT;
    }

     public static Series InfoSeries(int idSerie)
    {
        Series InfoS = new Series();
        string SQL = "SELECT * FROM Series WHERE IdSerie = @idSer";
        using (SqlConnection db = new SqlConnection(connectionString))
        {
            InfoS = db.QueryFirstOrDefault<Series>(SQL, new{idSer = idSerie});
        }
        return InfoS;
    }

     public static Actores InfoActores(int idActor)
    {
        Actores InfoA = new Actores();
        string SQL = "SELECT * FROM Actores WHERE IdActor = @idAct";
        using (SqlConnection db = new SqlConnection(connectionString))
        {
            InfoA = db.QueryFirstOrDefault<Actores>(SQL, new{idAct = idActor});
        }
        return InfoA;
    }

    public static List<Temporadas> ListarTemporadas()
    {
        List<Temporadas> ListaTemporadas = new List<Temporadas>();
        string SQL = "SELECT * FROM Temporadas";
        using (SqlConnection db = new SqlConnection(connectionString))
        {
            ListaTemporadas = db.Query<Temporadas>(SQL).ToList();
        }
        return ListaTemporadas;
    }

    public static List<Series> ListarSeries()
    {
        List<Series> ListaSeries = new List<Series>();
        string SQL = "SELECT * FROM Series";
        using (SqlConnection db = new SqlConnection(connectionString))
        {
            ListaSeries = db.Query<Series>(SQL).ToList();
        }
        return ListaSeries;
    }

    public static List<Actores> ListarActores()
    {
        List<Actores> ListaActores = new List<Actores>();
        string SQL = "SELECT * FROM Actores";
        using (SqlConnection db = new SqlConnection(connectionString))
        {
            ListaActores = db.Query<Actores>(SQL).ToList();
        }
        return ListaActores;
    }

}
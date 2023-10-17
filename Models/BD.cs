using System.Data.SqlClient;
using Dapper;
public static class BD
{
    private static string connectionString = @"Server=localhost;DataBase=BDSeries;Trusted_Connection=True;";


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

    public static List<Temporadas> ListarTemporadas(int idSerie)
    {
        List<Temporadas> ListaTemporadas = new List<Temporadas>();
        string SQL = "SELECT * FROM Temporadas Where IdSerie = @idSeriee";
        using (SqlConnection db = new SqlConnection(connectionString))
        {
            ListaTemporadas = db.Query<Temporadas>(SQL, new{idSeriee = idSerie}).ToList();
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

    public static List<Actores> ListarActores(int idSerie)
    {
        List<Actores> ListaActores = new List<Actores>();
        string SQL = "SELECT * FROM Actores Where IdSerie = @idSerieB";
        using (SqlConnection db = new SqlConnection(connectionString))
        {
            ListaActores = db.Query<Actores>(SQL, new{idSerieB = idSerie}).ToList();
        }
        return ListaActores;
    }

}
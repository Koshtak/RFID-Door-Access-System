using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

using static System.Runtime.InteropServices.JavaScript.JSType;

[ApiController]
[Route("api/[controller]")]
public class RfidController : ControllerBase
{
    [HttpGet("yetki")]
    public IActionResult YetkiKontrol(string kid)
    {
      
        using (var con = new SqlConnection("Server=Berkay\\SQLEXPRESS;Database=KayıtSistemiDB;Integrated Security = True; Encrypt = False"))

     
        {
            con.Open();
            var cmd = new SqlCommand("SELECT yetki FROM Kayıt WHERE kid=@id", con);
            cmd.Parameters.AddWithValue("@id", kid);
            var yetki = cmd.ExecuteScalar();

            if (yetki != null && (bool)yetki)
                return Ok("true");
            else
                return Ok("false");
        }
    }
}
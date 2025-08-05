using Application.Feature.Paciente.Commands;
using Application.Interfaces.Services;
using Dapper;
using Domain.Entities.Services.Paciente;
using Domain.Entities.Services.Rol;
using Infraestructure.DbContext.Interface;

namespace Infraestructure.Repository
{
    public class PacienteRepository : IPacienteService
    {
        private readonly IAppDbContext _appDbContext;

        public PacienteRepository(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> CrearPaciente(CrearPacienteCommand rq)
        {
            const string query = @"INSERT INTO public.paciente 
                        (nombres, apellidos, edad, sexo, cel, direccion, idlugar, tipoconsulta, tipopaciente)
                        VALUES
                        (:nombres, :apellidos, :edad, :sexo::ty_sexo , :cel, :direccion, :idlugar, :tipoconsulta::tipconty, :tipopaciente::tippacty)";
            using var connection = _appDbContext.ObtenerConexion();
            int filaAfectadas = await connection.ExecuteAsync(query, rq);
            return filaAfectadas > 0;
        }

        public async Task<bool> EditarPaciente(EditarPacienteCommand rq)
        {
            const string query = @"UPDATE paciente
                                        SET 
                                            nombres = :Nombres,
                                            apellidos = :Apellidos,
                                            edad = :Edad,
                                            sexo = :Sexo::ty_sexo,
                                            cel = :Cel,
                                            direccion = :Direccion,
                                            idlugar = :IdLugar,
                                            tipoconsulta = :tipoconsulta::tipconty,
                                            tipopaciente = :tipopaciente::tippacty
                                        WHERE id = :Id";

            using var connection = _appDbContext.ObtenerConexion();
            int filaAfectadas = await connection.ExecuteAsync(query, rq);
            return filaAfectadas > 0;
        }

        public async Task<bool> EstadoAtendido(long idPaciente)
        {
            const string query = @"
                                    UPDATE paciente
                                    SET estado = 'atendido'::estpacty
                                    WHERE id = :idPaciente";

            using var connection = _appDbContext.ObtenerConexion();
            int filasAfectadas = await connection.ExecuteAsync(query, new { idPaciente });
            return filasAfectadas > 0;
        }

        public async Task<PacienteResponse> ObtenerPacienteById(long idPaciente)
        {
            const string query = @"SELECT p.id, p.nombres, p.apellidos, p.edad, p.sexo, p.cel, p.direccion, p.idlugar, l.nombre nombreLugar FROM paciente p
                                    join lugar l on l.id = p.idlugar 
                                    WHERE p.id = :idPaciente";

            using var connection = _appDbContext.ObtenerConexion();
            return await connection.QueryFirstOrDefaultAsync<PacienteResponse>(query, new { idPaciente });
        }

        public async Task<IList<PacienteResponse>> ObtenerPacienteByLugar(long idlugar)
        {
            const string query = @"SELECT p.id, p.nombres, p.apellidos, p.edad, p.sexo, p.cel, p.direccion, p.idlugar, l.nombre nombreLugar, p.tipoconsulta, p.tipopaciente, p.estado FROM paciente p
                                    join lugar l on l.id = p.idlugar                                     
                                    WHERE idlugar = :idlugar
                                    order by p.id";

            using var connection = _appDbContext.ObtenerConexion();
            return (await connection.QueryAsync<PacienteResponse>(query, new { idlugar })).ToList(); ;
        }

        public async Task<IList<PacienteResponse>> ObtenerPacienteByNombre(string nombreLugar)
        {
            const string query = @"select p.id, p.nombres, p.apellidos, p.edad, p.sexo, p.cel, p.direccion, p.idlugar, l.nombre nombreLugar from paciente p
                                    join lugar l on l.id = p.idlugar 
                                    where UPPER(CONCAT(p.nombres, p.apellidos)) like concat('%', upper(:nombreLugar), '%') ";
            using var connection = _appDbContext.ObtenerConexion();
            return (await connection.QueryAsync<PacienteResponse>(query, new { nombreLugar })).ToList();
        }

        public async Task<PacienteResponse> ObtenerPacienteByNombreIgual(string nombrePaciente)
        {
            const string query = @"SELECT 
                                            p.id, 
                                            p.nombres, 
                                            p.apellidos, 
                                            p.edad, 
                                            p.sexo, 
                                            p.cel, 
                                            p.direccion, 
                                            p.idlugar,
                                            l.nombre nombreLugar 
                                        FROM paciente p
                                        JOIN lugar l ON l.id = p.idlugar 
                                        WHERE UPPER(CONCAT(p.nombres, ' ', p.apellidos)) = :nombrePaciente";
            using var connection = _appDbContext.ObtenerConexion();
            return await connection.QueryFirstOrDefaultAsync<PacienteResponse>(query, new { nombrePaciente });
        }
    }
}

using System.Collections.Generic;

namespace TallerFinal.DAL
{
    interface IRepositorio<TEntity>
    {
        void Agregar(TEntity pEntity);
        void Eliminar(TEntity pEntity);
        TEntity Obtener(int pId);
        IEnumerable<TEntity> ObtenerTodos();
        int Count();
        void GuardarCambios();
    }
}

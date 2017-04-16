namespace mContent.Domain.Interfaces.Entities.Base
{
    using System;

    public interface IEntityBase
    {
        /// <summary>
        /// Obtém ou define o identificador único.
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Obtém ou define a data de criação.
        /// </summary>
        DateTime CreatedDate { get; set; }

        /// <summary>
        /// Obtém ou define a data de atualização. Não obrigatório na inserção. Obrigatório somente na atualização.
        /// </summary>
        DateTime? UpdatedDate { get; set; }
    }
}
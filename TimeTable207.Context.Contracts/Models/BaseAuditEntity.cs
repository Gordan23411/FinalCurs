namespace AgenstvoNedvizimosty.Context.Contracts.Models
{
    public abstract class BaseAuditEntity
    {
        /// <summary>
        /// Индентификация
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// когда создан
        /// </summary>
        public DateTimeOffset CreateAt { get; set; }

        /// <summary>
        /// кем создан
        /// </summary>
        public string CreateBy { get; set; } = string.Empty;

        /// <summary>
        /// когда создан
        /// </summary>
        public DateTimeOffset UpdateAt { get; set; }

        /// <summary>
        /// кем изменен 
        /// </summary>

        public string UpdateBy { get; set; } = string.Empty;

        /// <summary>
        /// дата удаления
        /// </summary>
        public DateTimeOffset? DeletedAt { get; set; }
    }
}

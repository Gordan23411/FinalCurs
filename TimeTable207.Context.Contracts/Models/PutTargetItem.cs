namespace AgenstvoNedvizimosty.Context.Contracts.Models
{
    /// <summary>
    /// О путевке 
    /// </summary>
    public class PutTargetItem : BaseAuditEntity
    {
        /// <summary>
        /// id
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// Номер путевки
        /// </summary>
        public Guid TargetID { get; set; }

        /// <summary>
        /// количество ночей
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Общая стоимость
        /// </summary>
        public decimal Summ { get; set; }
    }
}

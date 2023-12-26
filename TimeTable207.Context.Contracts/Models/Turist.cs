namespace AgenstvoNedvizimosty.Context.Contracts.Models
{
    /// <summary>
    /// О туристах
    /// </summary>
    public class Turist : BaseAuditEntity
    {
        /// <summary>
        /// ФИО
        /// </summary>
        public string NFO { get; set; } = string.Empty;

        /// <summary>
        /// Серия и номер паспорта
        /// </summary>
        public string SeriesAndNomerPass { get; set; } = string.Empty;

        /// <summary>
        /// почта
        /// </summary>
        public string email { get; set; } = string.Empty;

        /// <summary>
        /// НомерТелефон
        /// </summary>
        public string PhoneNumber { get; set; } = string.Empty;
    }
}

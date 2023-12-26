namespace AgenstvoNedvizimosty.Context.Contracts.Models
{
    /// <summary>
    /// О тур операторе
    /// </summary>
    public class TurOper: BaseAuditEntity
    {
        /// <summary>
        /// Имя туроперов
        /// </summary>
        public string NameOper { get; set; } = string.Empty;

        /// <summary>
        /// Юридический адресс
        /// </summary>
        public string UrAdress { get; set; } = string.Empty;

        /// <summary>
        /// Факт Адресс
        /// </summary>
        public string FactAdress { get; set; } = string.Empty;

        /// <summary>
        /// ИНН
        /// </summary>
        public string INN { get; set; } = string.Empty;

        /// <summary>
        /// ОКПО
        /// </summary>
        public string OKPO { get; set; } = string.Empty;

    }
}

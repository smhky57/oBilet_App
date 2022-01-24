namespace WebApplication1.Models
{
    public class Journey : Query
    {
        #region private
        private List<JourneyDetail> m_JourneyDetails = new List<JourneyDetail>();
        #endregion
        #region public
        public List<JourneyDetail> JourneyDetails { get { return m_JourneyDetails; } set { m_JourneyDetails = value; } }
        #endregion
    }
}

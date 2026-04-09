
#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IHumanloopClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingBearer(
            string apiKey);
    }
}
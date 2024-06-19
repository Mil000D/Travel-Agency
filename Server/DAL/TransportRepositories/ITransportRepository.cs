using MASProject.Server.Models.TransportModels;

namespace MASProject.Server.DAL.TransportRepositories
{
    /// <summary>
    /// Generic interface for transport repository operations.
    /// </summary>
    /// <typeparam name="T">Type of transport, must inherit from <see cref="Transport"/>.</typeparam>
    public interface ITransportRepository<T> where T : Transport
    {
        /// <summary>
        /// Asynchronously adds a transport.
        /// </summary>
        /// <param name="transport">The transport to add.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        public Task AddTransportAsync(T transport);

        /// <summary>
        /// Asynchronously deletes a transport by ID.
        /// </summary>
        /// <param name="id">The ID of the transport to delete.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        public Task DeleteTransportAsync(int id);

        /// <summary>
        /// Asynchronously retrieves a transport by ID.
        /// </summary>
        /// <param name="id">The ID of the transport to retrieve.</param>
        /// <returns>A Task representing the asynchronous operation, with the transport as the result.</returns>
        public Task<T?> GetTransportAsync(int id);

        /// <summary>
        /// Asynchronously retrieves all transports.
        /// </summary>
        /// <returns>A Task representing the asynchronous operation, with a list of transports as the result.</returns>
        public Task<List<T>> GetTransportsAsync();

        /// <summary>
        /// Asynchronously updates a transport.
        /// </summary>
        /// <param name="transport">The transport to update.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        public Task UpdateTransportAsync(T transport);
    }
}

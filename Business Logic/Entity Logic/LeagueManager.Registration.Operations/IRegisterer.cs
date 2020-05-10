using LeagueManager.Leagues.Models;
using LeagueManager.Registration.Models;
using System.Collections.Generic;

namespace LeagueManager.Registration.Operations
{
    public interface IRegisterer
    {
        /// <summary>
        /// Register a player (Registrant) for a league-season
        /// </summary>
        /// <param name="personToRegister"></param>
        /// <param name="leageSeasonToRegisterFor"></param>
        /// <returns>A new registration record</returns>
        IRegistration RegisterForLeagueByAge(IRegistrant personToRegister, ILeagueSeason leageSeasonToRegisterFor);

        /// <summary>
        /// Undo an existing registration
        /// </summary>
        /// <remarks>
        /// The mechanics of de-registering is left to the implementation. It could be a matter of deleting
        /// the registration record, setting a marker that a registration has been reversed, etc.
        /// </remarks>
        /// <param name="registrationToDeregister"></param>
        void Deregister(IRegistration registrationToDeregister);
    }

    /// <summary>
    /// Converts an item of <typeparamref name="TSourceData"/> into an <see cref="IRegistration"/>.
    /// </summary>
    /// <typeparam name="TSourceData">The type that defines the source data. In most cases this is string. But may be a complex type.</typeparam>
    public interface IBulkRegistrationConverter<TSourceData>
    {
        IRegistration ParseRegistration(TSourceData source);
    }

    /// <summary>
    /// A source of bulk registration data.
    /// </summary>
    /// <typeparam name="TSourceData">The type that defines the source data. In most cases this is string. But may be a complex type.</typeparam>
    public interface IBulkRegistrationSource<TSourceData>
    {
        IBulkRegistrationConverter<TSourceData> Parser { get; }
        ICollection<TSourceData> SourceData { get; }
    }

    public interface IBulkRegisterer
    {
        /// <summary>
        /// Use the converter embedded in the source definition to import the source data as a set of registrations.
        /// </summary>
        /// <typeparam name="TSourceData">The type that defines the source data. In most cases this is string. But may be a complex type.</typeparam>
        /// <param name="source"></param>
        /// <returns>The registrations that have been loaded.</returns>
        /// <remarks>
        /// It is left to the implementation to determine whether the registrations are stored permanently as part of the loading, or done "in-memory"
        /// in order to interactively view the data (or summary) before storing permanently in a different step.
        /// </remarks>
        ICollection<IRegistration> LoadRegistrationsFromSource<TSourceData>(IBulkRegistrationSource<TSourceData> source);
    }
}

using System;

namespace BachelorTherasoftDotnetDomain.Interfaces;

public interface IParticipantRepository
{
    Task UpdateFirstNameAsync(string participantId, string firstName);
    Task UpdateLastNameAsync(string participantId, string lastName);
    Task UpdateEmailAsync(string participantId, string email);
    Task UpdateAddressAsync(string participantId, string address);
    Task DeleteAsync(string participantId);
}

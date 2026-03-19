using fixAL_Backend.DTOs.Message;

namespace fixAL_Backend.Interfaces;

public interface IMessageServices
{
        Task SendMessage(int senderId, SendMessageDto messageDto);
        Task<List<MessageDto>> GetConversation(int userAId, int  userBId);
        Task DeleteMessage(int id, int requestingUserId);
}
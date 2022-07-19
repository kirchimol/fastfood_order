using bot.Constants;
using bot.Helpers;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace fastfood_order.Services;

public partial class BotUpdateHandler
{
    private async Task Settings(ITelegramBotClient botClient, Message message, CancellationToken token)
   {

        await botClient.SendTextMessageAsync(
            chatId: message.Chat.Id,
            text: $"Nimani o'zgartirmoqchisiz?",
            replyMarkup: MarkupHelpers.GetReplyKeyboardMarkup(StringConstants.SettingButtons.Values.ToArray(), 3),
            parseMode: ParseMode.Html,
            cancellationToken: token
        );
   } 
}
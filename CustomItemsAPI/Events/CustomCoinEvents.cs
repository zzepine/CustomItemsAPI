using CustomItemsAPI.Items;
using LabApi.Features.Wrappers;

namespace CustomItemsAPI.Events;

/// <summary>
/// Events for calling methods for <see cref="CustomCoinBase"/>.
/// </summary>
public static class CustomCoinEvents
{
    public static event Action<CustomCoinBase, Player, CoinItem, TypeWrapper<bool>, TypeWrapper<bool>>? Flipping;
    public static event Action<CustomCoinBase, Player, CoinItem, bool>? Flipped;

    public static void OnFlipping(CustomCoinBase customItem, Player player, CoinItem coin, TypeWrapper<bool> isTails, TypeWrapper<bool> isAllowedHelper)
        => Flipping?.Invoke(customItem, player, coin, isTails, isAllowedHelper);

    public static void OnFlipped(CustomCoinBase customItem, Player player, CoinItem coin, bool isTails)
        => Flipped?.Invoke(customItem, player, coin, isTails);
}
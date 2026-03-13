using System;
using System.Collections.Generic;


Inventory inventory = new Inventory(3);

Console.WriteLine($"=== 인벤토리 테스트 ===");
TryAddItem("검");
TryAddItem("방패");
TryAddItem("포션");
TryAddItem("활");


Console.WriteLine();

inventory.ShowItems();
TryRemoveItem("포션");
TryRemoveItem("도끼");


Console.WriteLine();

inventory.ShowItems();





void TryAddItem(string item)
{
    try
    {
        inventory.AddItem(item);
    }
    catch (InventoryFullException ex)
    {
        Console.WriteLine($"{ex.Message} (용량: {ex.Capacity}, 아이템: {ex.ItemName})");
    }
}

void TryRemoveItem(string item)
{
    try
    {
        inventory.RemoveItem(item);
    }
    catch (ItemNotFoundException ex)
    {
        Console.WriteLine($"{ex.Message} {ex.ItemName}");
    }
}
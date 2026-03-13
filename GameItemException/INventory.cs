using System;
using System.Collections.Generic;
using System.Text;


public class Inventory
{
    private int maxCapacity;
    private List<string> items;

    public Inventory(int capacity)
    {
        maxCapacity = capacity; 
        items = new List<string>();
    }


    public void AddItem(string item)
    {
        if (items.Count >= maxCapacity)
        {
            throw new InventoryFullException($"[인벤토리 오류] 인벤토리가 가득 찼습니다.", item, items.Count);
        }

        Console.WriteLine($"아이템 \'{item}\' 추가됨");
        items.Add(item);
    }

    public void RemoveItem(string item)
    {
        if (!items.Contains(item))
        {
            throw new ItemNotFoundException($"[인벤토리 오류] 아이템을 찾을 수 없습니다:", item);
        }

        Console.WriteLine($"아이템 \'{item}\' 제거됨");
        items.Remove(item);
    }

    public void ShowItems()
    {
        Console.WriteLine($"현재 인벤토리: {string.Join(", ", items)}");
    }
}



public class InventoryFullException : Exception
{
    public string ItemName { get; private set; }
    public int Capacity { get; private set; }

    public InventoryFullException() :base() { }
    public InventoryFullException(string message) : base(message) { }
    public InventoryFullException(string message, string item, int capacity) : base(message) { ItemName = item; Capacity = capacity; }
}

public class ItemNotFoundException : Exception
{
    public string ItemName { get; private set; }

    public ItemNotFoundException() :base() { }
    public ItemNotFoundException(string message) :base(message) { }
    public ItemNotFoundException(string message, string item) :base(message) { ItemName = item; }
}
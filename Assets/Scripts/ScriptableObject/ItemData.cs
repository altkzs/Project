using System;
using UnityEngine;

public enum ItemType
{
	Resource,//자원
	Consumable//소비가능
}
public enum ConsumableType
{
	Health
}
[Serializable]
public class ItemDataConsumable
{
	public ConsumableType type;
}

[CreateAssetMenu(fileName = "Item", menuName = "New Item")]
public class ItemData : ScriptableObject
{
	[Header("Info")]
	public string displayName;
	public string description;
	public ItemType type;
	public Sprite icon;
	public GameObject dropPrefab;

	[Header("Stacking")]
	public bool canStack;
	public int maxStackAmount;

	[Header("Consumable")]
	public ItemDataConsumable[] consumables;

}

using System;

namespace MarsRover.Interfaces
{
    public interface IEnumOperation
    {
        T GetEnumFromDescription<T>(string description) where T : Enum;
        int GetEnumItemsCount<T>();
        string GetEnumDescription<T>(Enum item) where T : Enum;
    }
}

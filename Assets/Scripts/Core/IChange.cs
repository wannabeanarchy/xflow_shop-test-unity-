using System;

namespace GameTest.Core
{ 
	public interface IChange
	{
		event Action OnChanged; 
	}
}
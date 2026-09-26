using Prototype;
using Prototype.Enum;

var strategyOriginal = new Strategy
{
    Account = "TEST123",
    OrderType = OrderTypeEnum.Buy,
    Instrument = "EMBJ3",
    Quantity = 100,
    Price = 101.52m,
    LossLimit = 20.0m,
    RiskConfiguration = new Risk { StopLoss = 100.00m, TakeProfit = 102.00m } 
};

DisplayStrategyInfo(strategyOriginal, "Original");

var strategyClone = (Strategy)strategyOriginal.Clone();
DisplayStrategyInfo(strategyClone, "Cloned | Shallow Copy");

var strategyDeepCopy = (Strategy)strategyOriginal.DeepCopy();
DisplayStrategyInfo(strategyDeepCopy, "Deep Copied");

Console.WriteLine("\nSobrescreve o valor das propriedades------------------------------");
strategyOriginal.OrderType = OrderTypeEnum.Sell; // Aqui temos um enum que funciona como value type, então a alteração não afetará as cópias
strategyOriginal.RiskConfiguration.StopLoss = 90.00m;
strategyOriginal.RiskConfiguration.TakeProfit = 122.00m; // Aqui temos o objeto aninhado e veremos diferença entre cópia rasa e cópia profunda
DisplayStrategyInfo(strategyOriginal, "Original");
DisplayStrategyInfo(strategyClone, "Cloned | Shallow Copy");
DisplayStrategyInfo(strategyDeepCopy, "Deep Copied");

// Se eu der um new Risk() para o objeto aninhado, a cópia rasa não será afetada
Console.WriteLine("\nCria novo objeto------------------------------");
strategyOriginal.RiskConfiguration = new Risk { StopLoss = 80.00m, TakeProfit = 132.00m };
DisplayStrategyInfo(strategyOriginal, "Original");
DisplayStrategyInfo(strategyClone, "Cloned | Shallow Copy");
DisplayStrategyInfo(strategyDeepCopy, "Deep Copied");

Console.WriteLine("\nRenomeia um value type string------------------------------");
strategyClone.Account = "CLONE456";
DisplayStrategyInfo(strategyClone, "Cloned | Shallow Copy");

strategyDeepCopy.Account = "DEEP789";
DisplayStrategyInfo(strategyDeepCopy, "Deep Copied");


void DisplayStrategyInfo(Strategy strategy, string strategyType)
{
    Console.WriteLine("\n------------------------------");
    Console.WriteLine($"\n{strategyType} Strategy:");
    Console.WriteLine($"Account: {strategy.Account}");
    Console.WriteLine($"Order Type: {strategy.OrderType}");
    Console.WriteLine($"Instrument: {strategy.Instrument}");
    Console.WriteLine($"Quantity: {strategy.Quantity}");
    Console.WriteLine($"Price: {strategy.Price}");
    Console.WriteLine($"Loss Limit: {strategy.LossLimit}");
    Console.WriteLine($"Risk Configuration - Stop Loss: {strategy.RiskConfiguration.StopLoss}, Take Profit: {strategy.RiskConfiguration.TakeProfit}");
    Console.WriteLine($"Created At: {strategy.CreatedAt}");
}

//Financial Forecast

using System;
using System.Collections.Generic;

class FinancialForecast
{
    private List<double> historicalData;

    public FinancialForecast(List<double> historicalData)
    {
        this.historicalData = historicalData;
    }

    public double PredictNext()
    {
        int n = historicalData.Count;
        double sumX = 0, sumY = 0, sumXY = 0, sumXX = 0;

        for (int i = 0; i < n; i++)
        {
            double x = i + 1;
            double y = historicalData[i];

            sumX += x;
            sumY += y;
            sumXY += x * y;
            sumXX += x * x;
        }

        double slope = (n * sumXY - sumX * sumY) / (n * sumXX - sumX * sumX);
        double intercept = (sumY - slope * sumX) / n;

        double nextX = n + 1;
        return intercept + slope * nextX;
    }

    static void Main()
    {
        List<double> revenues = new List<double> { 10000.0, 12000.0, 12500.0, 15000.0, 16000.0 };
        FinancialForecast forecast = new FinancialForecast(revenues);

        double nextMonthPrediction = forecast.PredictNext();
        Console.WriteLine($"Predicted revenue for next month: ${nextMonthPrediction:F2}");
    }
}
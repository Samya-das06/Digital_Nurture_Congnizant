//Financial Forecasting system

import java.util.*;

public class FinancialForecast {
    private List<Double> historicalData;
    public FinancialForecast(List<Double> historicalData) {
        this.historicalData = historicalData;
    }
    public double predictNext() {
        int n = historicalData.size();
        double sumX = 0, sumY = 0, sumXY = 0, sumXX = 0;
        for (int i = 0; i < n; i++) {
            double x = i + 1;
            double y = historicalData.get(i);
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
    public static void main(String[] args) {
        List<Double> revenues = Arrays.asList(10000.0, 12000.0, 12500.0, 15000.0, 16000.0);
        FinancialForecast forecast = new FinancialForecast(revenues);
        double nextMonthPrediction = forecast.predictNext();
        System.out.printf("Predicted revenue for next month: $%.2f\n", nextMonthPrediction);
    }
}
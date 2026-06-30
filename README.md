# Stock-Reader
reads and displays stock data through charts.

# Stock Candlestick Pattern Recognition

A Windows Forms application built in C# for visualizing stock market candlestick charts and automatically identifying common candlestick patterns. This project extends previous versions by introducing inheritance and polymorphism to implement reusable pattern recognizers and annotate detected patterns directly on the chart.

## Overview

This application reads historical stock data from CSV files and displays candlestick charts for one or more selected stocks. Users can filter the displayed data by date range, choose different time periods (daily, weekly, monthly, yearly), and automatically identify common candlestick patterns using runtime-selectable recognizers.

Project 3 focuses on applying object-oriented programming concepts such as inheritance, polymorphism, virtual methods, and derived classes to create an extensible candlestick pattern recognition system.

## Features

* Load one or multiple stock CSV files.
* Display candlestick charts using Windows Forms Chart controls.
* Filter displayed data by start and end date.
* Update charts without restarting the application.
* Support daily, weekly, monthly, and yearly stock data.
* Runtime-loaded pattern selection using a ComboBox.
* Detect multiple candlestick patterns.
* Display detected patterns using chart annotations.
* Option to preserve existing annotations or clear them before displaying new ones.

## Supported Patterns

* Marubozu
* Bullish Marubozu
* Bearish Marubozu
* Engulfing Pattern
* Bullish Engulfing Pattern
* Bearish Engulfing Pattern

## Object-Oriented Design

The application demonstrates several core object-oriented programming concepts:

* Inheritance through the `aSmartCandlestick` class derived from `aCandlestick`.
* Polymorphism using a common `aRecognizer` base class.
* Virtual methods for implementing pattern-specific matching logic.
* Separate recognizer classes for each candlestick pattern.
* Conversion of standard candlesticks into smart candlesticks for analysis.

## Technologies Used

* C#
* Windows Forms
* .NET Framework / .NET
* Visual Studio
* System.Windows.Forms.DataVisualization.Charting

## How to Run

1. Clone this repository.
2. Open the solution (`.sln`) in Visual Studio.
3. Build the project.
4. Run the application.
5. The program initially loads the default ABBV stock data.
6. Use the **Load** button to select additional stock CSV files.
7. Adjust the date range if desired.
8. Select a candlestick pattern from the ComboBox to highlight matching occurrences on the chart.

## Project Structure

* **aCandlestick** – Base candlestick representation.
* **aSmartCandlestick** – Extended candlestick with additional functionality for pattern recognition.
* **aRecognizer** – Abstract/base recognizer class.
* **Pattern Recognizers** – Individual recognizer classes implementing specific candlestick patterns.
* **Windows Forms UI** – Handles stock loading, chart display, user interaction, and annotations.

## Concepts Demonstrated

* Object-oriented programming
* Inheritance
* Polymorphism
* Virtual methods
* Event-driven programming
* Data visualization
* CSV file parsing
* Collection processing
* Windows Forms development

## Future Improvements

* Support additional candlestick patterns.
* Export annotated charts as images.
* Improve chart customization options.
* Add technical indicators such as moving averages and RSI.
* Enhance CSV validation and error handling.

## Author

Developed as part of a Computer Science course project exploring object-oriented software design and Windows Forms application development.

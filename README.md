# Assignment 1 Pattern Matching

## Description

This console application asks the user to enter a regular expression and an input string. It then checks whether the input matches the regular expression.

If the user presses ENTER without typing a regular expression, the program uses the default pattern `\d+`, which checks for one or more digits.

## How to Run

1. Open the project folder in a terminal.
2. Build the program with `dotnet build`.
3. Run the program with `dotnet run`.
4. Enter a regex pattern, or press ENTER to use the default.
5. Enter text to test against the pattern.

## Example

- Pattern: `^[a-z]+$`
- Input: `apples`
- Result: `"apples" matches "^[a-z]+$": True`

## Error Handling

If the user enters an invalid regular expression, the program shows an error message instead of crashing.
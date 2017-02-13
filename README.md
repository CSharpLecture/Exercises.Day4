# Exercises.Day4

Exercises and solutions for the fourth day.

## 16. Communication between Forms

Write a small Windows Forms application that consists of two windows (forms). The first (main) window should have a `ComboBox` with two values, "blocking" and "non-blocking", a `Button` and an empty `Label`.

The second window should have a `TextBox` and two `Button` controls, one with the text being "OK" and another one with the text being "Cancel".

Pressing the button in the main window should open the second window. If the value "blocking" has been selected from the `ComboBox` control, then the `ShowDialog()` method should be picked, otherwise the `Show()` method is the way to go.

The second window should be closed on pressing one of the buttons. The difference between the two buttons is, however, that the OK button does also "transmit" the value in textbox to the label of the main window.

## 17. Getting to know the .NET-Framework

Place a variety of controls on a `Form` and display some of the information you can read out using the `Environment` class like the current username and the current directory.

## 18. Reaction speed

Write a Windows Forms application that measures the reaction speed using the classes `Random`, `Timer` and `Stopwatch`. The `Timer` can be placed per drag and drop on the `Form` as a control.

First you use a random number to determine the value for the timer (when to display a label, that the button can now be pressed). Then, when the timer is firing it's elapsed event, start a new stopwatch measurement. Once the user presses the button the stopwatch should be stopped and the reaction time should be displayed.

## 19. A set of simple LINQ queries

Start by using the following LINQ query:

    var random = new Random();
    var list = Enumerable.Range(0, 100).Select(m => random.Next(0, 1000)).ToArray();

Create now a set of new variables based on the variable *list*. In total create the following variables with LINQ:

* Find the minimum element *min* in *list*.
* Find the maximum element *max* in *list*.
* Save the ordered array as a `List<int>` in *ordered*.
* Save all odd elements of *list* in *onlyodd*.
* Take only the 10 elements after the first 15 elements and save them as an array in *elements*.
* Take the first element that is bigger than 999 and save it in *hulk*.

## 20. A custom user control

Create a custom user control that contains a `Timer` control and a `Label` control as well as a `Button`. The user control should be a simple implementation of a timer app:

* Show the button with the text "Start" and the label with a time indicator (e.g. "Timer: 00m : 00s").
* When the button is pressed the time string on the label should count upwards.
* The button should be named "Stop" now. 
* When the button is pressed the timer stops counting.
* The button should now display "Reset". If it is being pressed, the initial state should be shown again.

Similarly, one could also implement a countdown user control.

## License
This work is licensed under a [Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License](http://creativecommons.org/licenses/by-nc-sa/4.0/).

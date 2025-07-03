# Drivers License Exam Checker

## Description

**Drivers License Exam Checker** is a simple Windows Forms application designed to evaluate student performance on a practice driver's license exam. The app reads the student's answers from a text file, compares them with the correct answers, and provides the user with a result (pass or fail). It also displays how many answers were correct, incorrect, and lists the specific questions that were answered incorrectly.

This application is ideal for students preparing for their driver's license exam or instructors who want to quickly assess student responses.

## Features

- **Answer Validation**: Compares student answers with correct answers.
- **Pass/Fail Result**: Shows whether the student passed (15 or more correct answers).
- **Incorrect Questions**: Displays which questions were answered incorrectly.
- **File Input**: Allows users to browse and load a text file with student answers.
- **Clear & Reset**: Clear the results and reset the input for new exams.

## Installation

1. **Clone or Download the Repository**  
   Clone this repository or download the project files to your local machine.

2. **Open the Project in Visual Studio**  
   Open the project in Visual Studio and build it using **Build** > **Build Solution**.

3. **Run the Application**  
   After building the project, run the application by selecting **Start** in Visual Studio or directly executing the compiled `.exe` file.

## How It Works

1. **Input Answers**:  
   The student’s answers should be stored in a text file, where each answer is on a separate line (A, B, C, or D).

2. **Load the Answer File**:  
   Click **Browse** to select the file containing the student’s answers, or manually enter the file path.

3. **Evaluate the Answers**:  
   Click **Read Results** to check the student's answers against the correct ones.

4. **View the Results**:  
   After evaluation, the application will display:
   - The number of correct answers.
   - The number of incorrect answers.
   - A list of question numbers that were answered incorrectly.
   - Whether the student passed or failed based on their performance.

5. **Clear Results**:  
   Click **Clear All** to reset the form for a new student or a new evaluation.

## Correct Answers

The correct answers are predefined in the program and are as follows:

1. B
2. D
3. A
4. A
5. C
6. A
7. B
8. A
9. C
10. D
11. B
12. C
13. D
14. A
15. D
16. C
17. C
18. B
19. D
20. A


## Requirements

- Windows Operating System (Windows 7 or later)
- .NET Framework 4.7.2 or later
- Visual Studio (for building the application)

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.


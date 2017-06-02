# Word Counter


#### By Jordan Loop; Date of current version: 6/2/2017

## Description

#### The user enters a single word and a sentence. The program will count how many times the single word is used in the sentence.

## Setup/Installation Requirements

* Download repository
* Using Windows PowerShell, Navigate to top level directory.
* In power shell type "dnx kestrel" (without the quotation marks).
* Open preferred web browser and type in the following URL: http://localhost:5004/

## Known Bugs

No know bugs.

## Questions/Concerns or advice?

Contact me at jordanloop@gmail.com

## Technologies Used

* ASP.NET 5
* C#
* HTML

### License

None.

## Specifications
| Behavior                                                                                                                                                             | Input (User Action/Selection)                                                                                       | Output (Program Action) | Why this behavior                                                          |
|----------------------------------------------------------------------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------|-------------------------|----------------------------------------------------------------------------|
| Program will compare two single word strings(case sensitive); returning 1 if they are the same or 0 if they are not the same.                                        | Input1: "Funky" Input2: "Funky"                                                                                     | Output: 1               | No data has been manipulated, simply checks equality.                      |
| Program will compare two single word strings(not case sensitive); returning 1 if they are the same or 0 if they are not the same.                                    | Input1: "Funky" Input2: "fUNkY"                                                                                     | Output: 1               | Minimal data manipulation required to pass as  true.                       |
| Program will compare a single word string to a multi word string; returning 1 if  the  single word string is present in multi-word string, returning 0 if it is not. | Input1: "Funky" Input2: "This party is funky"                                                                       | Output: 1               | Minimal change required to check Input1's equality to each word in Input2. |
| Program will compare a single word string to a multi word string; returning 1 if the single word string is present in multi-word string, returning 0 if it is not.   | Input1: "Funky" Input2: "This party is funky!"                                                                      | Output: 1               | Remove punctuation, then check for equality.                               |
| Program will compare a single word string to a multi word string; returning the total number of times the single word string is present in multi-word string.        | Input1: "Funky" Input2: "This party is so funky that I am going to say funky three more times. Funky, funky, funky! | Output: 5               | Includes a number that will increment each time "Funky" is present.        |

#Compiled App
/TextEditor/bin/Debug/FormApplication.exe

#Next version of TextPad
Implement a menubar that contains the following menus:

File

- New

- Open

- Save

- Save As

- Exit

Edit 

- Copy

- Cut

- Paste

- Select All

Help

- About

Place a separator between Save As and Exit.

1. If a menu item does not apply when the document is in a particular state then it should be made inactive (greyed out and not selectable). For example, if there is nothing to save, then Save should be made inactive. 

2. The New menu item is to provide the user with a blank document to edit a new document.

3. It should be possible for the user to save an empty document.

4. If the document has changed since the last time it was saved or since it was opened/created the user should be asked whether or not they want to save it if an action they are taking will cause the changes to be lost. They should have the option to save, not save, or cancel the action.

5. The Exit menu item should cause the application to close.

6. The About menu item is to display a dialog that contains information about the application and/or developer.

7. Make sure the TextBox UI element allows the user to enter multiple lines (accepts line returns) and allows the user to enter tabs in the content.

8. The right place to maintain information about the text document is in the TextDocument class. Make sure you use the Model-View-Controller paradigm and do not place user interface stuff in the TextDocument class.

9. Some menu icons are included.

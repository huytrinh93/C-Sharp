   M S B A M L   `   `   `  ����J  FFormApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FormApplicationFormApplication  5   	        FormApplication.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FormApplication     5   	   -   5          �Name$  window1��5   	    � Title$ Untitled - Text Editor��6   $��321.79��69   $��488.667��6I    � 
ResizeMode$ CanResizeWithGrip=�6Y    � 	Resources 5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $ Sources/FileIcon.xaml?�6%   �� 5      $ Sources/OpenIcon.xaml?�6%   %    5      .��5      � -   5         �Name$ grid1��5      $��35��6   $	��Top=�6&    � ColumnDefinitions 5   
   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   o� $��0��6   $��0��6   	 J� RenderTransformOrigin$	 0.459,0.641&�6,   .@�5      m� $
��File��6   $��63��6%   .@�5      m� -   5        
 m�Name$
 NewMenu��5      $	��New��6,    � ToolTip$ Create a new file��69    m� InputGestureText$ CTRL+N��6U    m� Icon 5      �� 5         FileIcon#��[  6    $��16��6C   $��16��6N   5       m� 5"      -   5        $
 OpenMenu��5"      $
��Open��6-   $ Open a file��6;   $ CRTL+O��6Q    5#      �� 5$        OpenIcon#��[ 6    $��16��6C   $��16��6N   5&      m� 5(      -   5        $
 SaveMenu��5(      $
��Save��6-   {�.  $ Saves the current file��6M   $ CTRL+S��6n   6�   m� 5)      -   5        $
 
SaveAsMenu��5)      $��SaveAs��6/   {�.  $ Saves the current file��6Q   6r   �� 5*      m� 5+      -   5        $
 ExitMenu��5+      $
��Exit��6-   $ Exits the program��6;   6W   5,      m� 5-      $
��Edit��6   $��64��6%   .@�5.      m�  m� Command$
 Undo��6   $ CTRL+Z��6*   m� 5/      $
 Redo��6   $ CTRL+Y��6*   �� 50      m� 51      $	 Cut��6   $ CTRL+X��6)   m� 52      $
 Copy��6   $ CTRL+C��6*   m� 53      $ Paste��6   $ CTRL+V��6+   �� 54      m� 55      $ 	SelectAll��6   $ CTRL+A��6/   56      m� 57      $
��Help��6   $��64��6%   .@�58      m� -   5        $
 
about_menu��58   *   $��About��6   6>   5:      5;      �� 5<   
   -	   5         ��Name$ textBox��5<      $��0��5=      $��1��6"   $��0,0,-338,-258q�5>       �� TextWrapping$ WrapWithOverflow=�5?      $ �� HorizontalScrollBarVisibility$ Disabled=�5@      " �� VerticalScrollBarVisibility$
 Auto=�6;    �� AcceptsReturn .  �� 
AcceptsTab . $��Times New Roman)�5B      $��17(�6/   $
��Left=�5C   L   $	��481��6g   $	��271��6s   $	��Top=�6�   5D      5H      5I      
   M S B A M L   `   `   `  ����@  <Snake, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Snake.PagesSnake.Pages  5      %    Snake.Pages.DifficultyLevelPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Snake.Pages     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      -   5          N� Title$  DifficultyLevelPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   � $��0��6    5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      �� -   5        $��Back_Button��5      $��0��5      $
��10,5q�5       $
��Left=�5!      $	��Top=�5"      
���   � �� IsCancel .  �� 	IsDefault .    MaterialDesignIconButton#��[  5'       � ToolTip$
 Back��5(      .��5)      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�6*   5*      �� 5+      -   5        $��Music_Button��5,      $��0��5-      $��0,5,60,5q�5.      $��Right=�5/      $	��Top=�50      
���   �#��[  54      .��55        -   5        $��
Music_Icon��55   *   $ Music=�6<   56      �� 57      -   5        $��Exit_Button��58      $��0��59      $
��10,5q�5:      $��Right=�5;      $	��Top=�5<      
���   �#��[  5?      $
 Exit��5@      .��5A        $ WindowClose=�6*   5B      �� 5C      $��0��5D      $	��530��5E      $	��150��5F      $/��)/Images/Settings/DifficultyLevel/Logo.png��5G      �� 5I      $��1��5J      $	��150��5K      $	��200��5L      $��Center=�5M      $5��//Images/Settings/DifficultyLevel/ImagedLogo.png��5N      5O      �� 5P   
   $��1��5Q      $��Center=�5R      $��Center=�5S      $��18(�5T      $
��Bold"�5U      ECYou have the possibility to choose between three difficulty levels.5W      �� 5X   
   $��2��5Y      $��Center=�5Z      $��Center=�5[      $��18(�5\      $
��Bold"�5]      Choose wisely ;)5_      � 5`   
   $��3��6    � ColumnDefinitions 5a      �� 5b      $��* �6#   �� 5c      $��* �6#   �� 5d      $��* �6#   .+�5f      �� -   5        $��
Left_Image��5g      $��0��5h      $	��130��5i      $	��130��5j      $5��//Images/Settings/DifficultyLevel/EasySnake1.png��5k      $y�Visible=�5l      � 5m      $��1��6    5n      �� 5o      $��* �6$   �� 5p      $
��auto �6$   �� 5q      $��* �6$   .+�5s      �� -   5        $��	Up_Button��5t      $��0��5u      $��Center=�5v      $��Bottom=�5w      
���   �#��[  5z      $ Harder��5{      .��5|        -   5        $��Up_Icon��5|   .   $ 	ChevronUp=�6=   5}      �� 5~      -	   5        $��Level_TextBlock��5      $��1��5�      $��Center=�5�      $��Center=�5�      $��30(�5�      $
��Bold"�5�      EASY5�      �� 5�      -
   5        $��Down_Button��5�      $��2��5�      $��Center=�5�      $	��Top=�5�      
���   �#��[  5�      $ Easier��5�      .��5�        -   5        $��	Down_Icon��5�   .   $ ChevronDown=�6?   5�      5�      �� 5�      -   5        $��Right_Image��5�      $��2��5�      $	��130��5�      $	��130��5�      $5��//Images/Settings/DifficultyLevel/EasySnake1.png��5�      $y�Visible=�5�      5�      5�      5�      
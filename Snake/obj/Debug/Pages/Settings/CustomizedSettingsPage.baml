   M S B A M L   `   `   `  ����@  <Snake, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Snake.Pages.SettingsSnake.Pages.Settings  5      1    +Snake.Pages.Settings.CustomizedSettingsPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Snake.Pages.Settings     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      -   5          N� Title$  CustomizedSettingsPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   � $��0��6    5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      �� -   5        $��Back_Button��5      $��0��5       $
��10,5q�5!      $
��Left=�5"      $	��Top=�5#      
���   � �� IsCancel .  �� 	IsDefault .    MaterialDesignIconButton#��[  5(       � ToolTip$
 Back��5)      .��5*      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�6*   5+      �� 5,      -   5        $��Music_Button��5-      $��0��5.      $��0,5,60,5q�5/      $��Right=�50      $	��Top=�51      
���   �#��[  55      .��56        -   5        $��
Music_Icon��56   *   $ Music=�6<   57      �� 58      -   5        $��Exit_Button��59      $��0��5:      $
��10,5q�5;      $��Right=�5<      $	��Top=�5=      
���   �#��[  5@      $
 Exit��5A      .��5B        $ WindowClose=�6*   5C      �� 5D      $��0��5E      $	��530��5F      $	��150��5G      $2��,/Images/Settings/CustomizedSettings/Logo.png��5H      5J      �� 5K   
   $��1��5L      $��0,20,0,0q�5M      
���   �$��0,0,0,0q�5O      ._�5P      �� $��	0,10,0,15q�5Q      $��Center=�5R      $��Center=�5S      $��18(�5T      $
��Bold"�5U      75The frequency with which the extra fruit will appear:5W      5X      � 5Y   
   $��2��6   $��0,0,0,0q�6    � ColumnDefinitions 5Z      �� 5[      $
��0.3* �6#   �� 5\      $
��0.4* �6#   �� 5]      $
��0.3* �6#   .+�5_      �� -   5        $��LeftBonusFruit_Image��5`      $��0��5a      $	��130��5b      $	��130��5c      $��Bottom=�5d      $A��;/Images/Settings/CustomizedSettings/BonusFruit/Normally.png��5e      $y�Visible=�5f      � 5g      $��1��6    5h      �� 5i      $
��auto �6'   �� 5j      $��* �6'   �� 5k      $
��auto �6'   .+�5m      �� -   5        $��LeftBonusFruit_Button��5n      $��0��5o      $��Center=�5p      $��Center=�5q      
���   �#��[  5t      $ 
Less often��5u      .��5v        -   5        $��Up_Icon��5v   .   $ ChevronLeft=�6=   5w      �� 5x      -	   5        $��BonusFruit_TextBlock��5y      $��1��5z      $��Center=�5{      $��Center=�5|      $��30(�5}      $
��Bold"�5~      
NORMALLY5�      �� 5�      -
   5        $��RightBonusFruit_Button��5�      $��2��5�      $��Center=�5�      $��Center=�5�      
���   �#��[  5�      $ 
More often��5�      .��5�        -   5        $��	Down_Icon��5�   .   $ ChevronRight=�6?   5�      5�      �� 5�      -   5        $��RightBonusFruit_Image��5�      $��2��5�      $	��130��5�      $	��130��5�      $��Bottom=�5�      $A��;/Images/Settings/CustomizedSettings/BonusFruit/Normally.png��5�      $y�Visible=�5�      5�      �� 5�   
   $��3��5�      $��0,35,0,0q�5�      
���   �$��0,0,0,0q�5�      ._�5�      �� $��	0,10,0,15q�5�      $��Center=�5�      $��Center=�5�      $��18(�5�      $
��Bold"�5�      *(The speed with which the hose will move:5�      5�      � 5�   
   $��4��6   $��0,0,0,0q�6    5�      �� 5�      $
��0.3* �6#   �� 5�      $
��0.4* �6#   �� 5�      $
��0.3* �6#   .+�5�      �� -   5        $��LeftDifficultyLevel_Image��5�      $��0��5�      $	��130��5�      $	��130��5�      $=��7/Images/Settings/CustomizedSettings/SnakeSpeed/Slow.png��5�      $y�Visible=�5�      � 5�      $��1��6    5�      �� 5�      $
��auto �6'   �� 5�      $��* �6'   �� 5�      $
��auto �6'   .+�5�      �� -   5        $ ��LeftDifficultyLevel_Button��5�      $��0��5�      $��Center=�5�      $��Center=�5�      
���   �#��[  5�      $ Slower��5�      .��5�        -   5        $��UpDifficultyLevel_Icon��5�   .   $ ChevronLeft=�6L   5�      �� 5�      -   5        $��DifficultyLevel_TextBlock��5�      $��1��5�      $��Center=�5�      $��Center=�5�      $��30(�5�      $
��Bold"�5�      SLOW5�      �� 5�      -   5        $!��RightDifficultyLevel_Button��5�      $��2��5�      $��Center=�5�      $��Center=�5�      
���   �#��[  5�      $ Faster��5�      .��5�        -   5        $��DownDifficultyLevel_Icon��5�   .   $ ChevronRight=�6N   5�      5�      �� 5�      -   5        $ ��RightDifficultyLevel_Image��5�      $��2��5�      $	��130��5�      $	��130��5�      $=��7/Images/Settings/CustomizedSettings/SnakeSpeed/Slow.png��5�      $y�Visible=�5�      5�      5�      5�      
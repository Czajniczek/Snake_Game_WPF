   M S B A M L   `   `   `  ����@  <Snake, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Snake.Pages.GameSnake.Pages.Game  5          Snake.Pages.Game.GamePage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Snake.Pages.Game     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          N� Title$  GamePage��5      .��5      � -   5        $��MainGrid��5       � RowDefinitions 5   
   �� 5      �� 5      $
��auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      $
��auto �6   �� 5      .+�5   
   �� -   5        $��PlayerNickname_StackPanel��5      $��0��5      $��1��5      $��Center=�5      $��Center=�5       �� Orientation$ Vertical=�5       .+�5!      �� $��Center=�6   $��20(�65   	Player:6L   �� 5"      -   5        $��PlayerNickname_TextBlock��5#      $��Center=�5$      $��20(�5%      $
��Bold"�5&      ��5'      ��  �� Path$ Nickname�5(      �� 5)   
   $��1��5*      $��1��5+      
���  ��$��5q�5-      ._�5.      �� -   5        $��
Playground��5/      $	��640��50      $	��440��51      
���   �52      53      � 54   
   $��2��55      $��0��56      $��3��57       58      �� 59      �� 5:      .+�5<      � $��0��6   .+�5=      �� $��	45,20,0,0q�6   $��20(�6/   DIFFICULTY LEVEL:6P   �� 5>      -   5        $��DifficultyLevel_TextBlock��5?      $��	10,20,0,0q�5@      $��20(�5A      $
��Bold"�5B      
CUSTOMIZED5D      5E      � 5F      $��1��6   .+�5G      �� $��
200,20,0,0q�6   $��20(�60   	POINTS:6G   �� 5H      -   5        $��Points_TextBlock��5I      $��	10,20,0,0q�5J      $��20(�5K      $
��Bold"�5L      05N      5O      5P      5Q      5R      
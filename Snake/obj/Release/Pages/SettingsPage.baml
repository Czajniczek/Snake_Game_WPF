   M S B A M L   `   `   `  ���� @  <Snake, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Snake.PagesSnake.Pages      Snake.Pages.SettingsPage   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     +localclr-namespace:Snake.Pages     b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  -     N� Title$  Snake: Settings��.���  � RowDefinitions �� $
��auto ��� $��* �.+�� $��0�� �� $
��auto ��� $
��auto �.+��� -   $��Back_Button��$��0��$
��10,5q�$
��Left=�$	��Top=�
���   � �� IsCancel .  �� 	IsDefault .    MaterialDesignIconButton#��[   � ToolTip$
 Back��.��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=��� -   $��Music_Button��$��0��$��0,5,60,5q�$��Right=�$	��Top=�
���   �#��[  .��  -   $��
Music_Icon��$ Music=��� -   $��Exit_Button��$��0��$
��10,5q�$��Right=�$	��Top=�
���   �#��[  $
 Exit��.��  $ WindowClose=��� $��0��$	��530��$	��105��$��/Images/Settings/Logo.png���� $��1��$	��200��$	��200��$��0,20,0,0q�$��Center=�$%��/Images/Settings/ImagedLogo.png��� $��1�� � ColumnDefinitions �� $��* ��� $��* ��� $��* �.+��� -   $��
Left_Image��$��0��$	��130��$	��130��$*��$/Images/Settings/DifficultyLevel.png��$y�Hidden=�� $��1��$��Center=� �� $��43 ��� $��43 ��� $��43 �.+��� -   $��DifficultyLevel_Button��$��0��$	��210��$��32��+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��
���   � .   MaterialDesignRaisedButton#��[ .��DIFFICULTY LEVEL�� -   $��OwnSettings_Button��$��1��$	��210��$��32��$ 5��
���   �#��[ .��CUSTOMIZED SETTINGS�� -	   $��MusicSettings_Button��$��2��$	��210��$��32��$ 5��
���   �#��[ .��MUSIC�� -
   $��Right_Image��$��2��$	��130��$	��130��$*��$/Images/Settings/DifficultyLevel.png��$y�Hidden=�
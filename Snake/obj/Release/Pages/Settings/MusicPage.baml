   M S B A M L   `   `   `  ���� @  <Snake, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Snake.PagesSnake.Pages      Snake.Pages.MusicPage   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  %localclr-namespace:Snake.Pages  b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  -     N� Title$  	MusicPage��.���  � RowDefinitions �� $
��auto ��� $
��auto ��� $��* �.+�� $��0�� �� $
��auto ��� $
��auto �.+��� -   $��Back_Button��$��0��$
��10,5q�$
��Left=�$	��Top=�
���   � �� IsCancel .  �� 	IsDefault .    MaterialDesignIconButton#��[   � ToolTip$
 Back��.��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=��� -   $��Music_Button��$��0��$��0,5,60,5q�$��Right=�$	��Top=�
���   �#��[  .��  -   $��
Music_Icon��$ Music=��� -   $��Exit_Button��$��0��$
��10,5q�$��Right=�$	��Top=�
���   �#��[  $
 Exit��.��  $ WindowClose=��� $��0��$	��105��$%��/Images/Settings/Music/Logo.png���� $��1��$	��150��$	��173��$��0,20,0,0q�$��Center=�$+��%/Images/Settings/Music/ImagedLogo.png���� $��1��$��0,30,0,0q�$��Center=�$��Center=�$��20(�$
��Bold"�#!Choose a song that interests you:� $��2�� � ColumnDefinitions �� $��0.15* ��� $
��0.7* ��� $��0.15* �.+�� $��1��$��Center=� �� $��43 ��� $��43 ��� $��43 �.+�� $��0�� �� �� $
��auto ��� .+��� -   $��LeftSnakeSong_Gif��$��0��$��60��$��40��"  WpfAnimatedGif.ImageBehavior   AnimatedSource$) #/Images/Settings/Music/MusicGif.gif��$y�Hidden=��� -   $��SnakeSong_Button��$��1��$	��210��$��32��+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��
���   � .   MaterialDesignRaisedButton#��[ .��
SNAKE SONG�� -   $��RightSnakeSong_Gif��$��2��$��60��$��40��$) #/Images/Settings/Music/MusicGif.gif��$y�Hidden=�� $��1�� �� �� $
��auto ��� .+��� -	   $��LeftBennyHillSong_Gif��$��0��$��60��$��40��$) #/Images/Settings/Music/MusicGif.gif��$y�Hidden=��� -
   $��BennySong_Button��$��1��$	��210��$��32��$ 5��
���   � . #��[ .��BENNY HILL YAKETY SAX�� -   $��RightBennyHillSong_Gif��$��2��$��60��$��40��$) #/Images/Settings/Music/MusicGif.gif��$y�Hidden=�
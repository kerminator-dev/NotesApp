   M S B A M L   `   `   `  ����C  ?NotesApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:NotesApp.ViewModelsNotesApp.ViewModels  5   	       NotesApp.Views.MainWindow   5   	   S OHandyControl, Version=3.3.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8
viewModels!clr-namespace:NotesApp.ViewModels     5   	   -   5        $��Window��5   	     � Title$  Notes��5	   	   $	��600��5
   	   $	��350��5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency$
 True��5   	    � WindowStartupLocation$ Manual=�5   	    � Topmost$
 True��5   	    � 	Resources 5         NoteTemplate �� DataType'   !NotesApp.ViewModels.NoteViewModel �� Triggers	 :� RoutedEvent
 W�Name �� TargetProperty W� From	 W� To g� Duration	 �� To �� 
TargetName g� FillBehavior ��Name � Cursor �� CornerRadius �� Padding � UseLayoutRounding �� BitmapScalingMode J� SnapsToDevicePixels �� ClearTypeHint J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   Color   
BlurRadius   	Direction   RenderingBias   ShadowDepth  �� Orientation! � ColumnDefinitions" � RowDefinitions# ��Name$ �� Path% �� Mode& ��Name' � ToolTip  ButtonCustom( �� RelativeSource) �� AncestorType-   'NotesApp.ViewModels.MainWindowViewModel��%�  &	        7  �� 5   
   "  6,    5      :� 5      $	 Loaded��6   .[�5      �� .��5      �� .��5      W� $
 OpacityAnimation��5   &   $ Opacity�5   !    0.05   !    1.06,   $ 	00:00:0.4D�65   5      5       5!      :� 5#      $	 
MouseEnter��6   .[�5%      �� .��5&      �� .��5'      ��  #6072ee6-   $ ControlBorder��5(   %   $1 +(Border.Background).(SolidColorBrush.Color)�5)   %   $ HoldEnd=�5*   %   $ 0:0:0D�5+   %   �� 5,       #dedefb6-   $ ControlBorder��5-   %   $ (Effect).(Color)�5.   %   $ HoldEnd=�5/   %   $ 0:0:0D�50   %   �� 51      	 White6-   $ TitleTextBlock��52   %   $4 .(TextBlock.Foreground).(SolidColorBrush.Color)�53   %   $ HoldEnd=�54   %   $ 0:0:0D�55   %   �� 56      	 White6-   $ ContentTextBlock��57   %   $4 .(TextBlock.Foreground).(SolidColorBrush.Color)�58   %   $ HoldEnd=�59   %   $ 0:0:0D�5:   %   �� 5;      	 White6-   $ CreatedTextBlock��5<   %   $4 .(TextBlock.Foreground).(SolidColorBrush.Color)�5=   %   $ HoldEnd=�5>   %   $ 0:0:0D�5?   %   5@      5A      5B      :� 5C      $	 
MouseLeave��6   .[�5E      �� .��5G      �� .��5I      �� 	 White6-   $ ControlBorder��5J   %   $1 +(Border.Background).(SolidColorBrush.Color)�5K   %   $ HoldEnd=�5L   %   $ 0:0:0D�5M   %   �� 5N       #e4e5e66-   $ ControlBorder��5O   %   $ (Effect).(Color)�5P   %   $ HoldEnd=�5Q   %   $ 0:0:0D�5R   %   �� 5S       #8c8c8c6-   $ 0:0:0D�5T   %   $ TitleTextBlock��5U   %   $4 .(TextBlock.Foreground).(SolidColorBrush.Color)�5V   %   $ HoldEnd=�5W   %   �� 5X       #8C8C8C6-   $ ContentTextBlock��5Y   %   $4 .(TextBlock.Foreground).(SolidColorBrush.Color)�5Z   %   $ HoldEnd=�5[   %   $ 0:0:0D�5\   %   �� 5]       #BEBEBF6-   $ CreatedTextBlock��5^   %   $4 .(TextBlock.Foreground).(SolidColorBrush.Color)�5_   %   $ HoldEnd=�5`   %   $ 0:0:0D�5a   %   5b      5c      5d      .R�5f      �� $ ControlBorder��6   $
 Hand��5g      
�������
�������$ 8��5j      $ 10q�5k      $��0 0 0 20q�5l      $
 True��5m      $ NearestNeighbor=�5n      $
 True��5o      $ Enabled=�5p       5r        5s      DropShadowEffect��$ #e4e5e6��5t      $ 8Q�5u      $	 -90Q�5v      $ Performance=�5w      $ 5Q�5x      ._�5z      ]� $��Stretch=�6   .+�5{      �� $  Vertical=�6!   $��Stretch=�5|      .+�5}      � ! 5~      �� 5   "   �� 5�   "   $
��auto �63   " 5�      �� 5�   "   $
��auto �60   .+�5�      �� $# TitleTextBlock��5�       $��0��5�   (   $��0��65   
������ ���#8c8c8c$
��auto��5�       $	��Top=�5�       $��17(�5�       $��Arial Rounded MT Bold)�5�       $��0 0 0 4q�5�       $
��Wrap=�5�       $��Normal"�5�       ��5�       �� $$ 
ShortTitle�$% OneTime=�5�       �� 5�      $& DeleteButton��6%   $��22��5�      $#' Удалить заметку��5�      $��22��5�      $��0��5�      $��1��5�      $
 Hand��5�      $��Right=�5�      $��12(�5�      $��Center=�5�      $��Center=�5�      
������ $y�Visible=�5�      $��4 0 0 0q�5�      
�������$	��✖��5�      8��  $��Arial)�5�      $��Normal"�5�      $��Normal$�61   $	��Top=�5�      ��5�      �� *ID+��5�      �� ( �� *FindAncestor+")  5�      5�      �� 5�      $# ContentTextBlock��5�      
������ ���#909090$��12(�5�      $
��auto��5�   M   $
��Left=�5�      $��Yu Gothic UI Semibold)�5�      $
��Wrap=�5�      ��5�      �� $$ ShortContent�$% OneTime=�5�      �� 5�      $# CreatedTextBlock��5�      $��0 5 0 0q�5�   $   
������ ���	#FFBEBEBF$��Arial Rounded MT Bold)�5�      $��11(�5�      $��Bottom=�5�      $��Right=�5�      ��5�      �� $$ ShortCreated�$% OneTime=�5�      5�      5�      5�      5�      5�      * � Triggers* 5�      :� 5�   
   $	 Window.Loaded��6   .[�5�      �� .��5�      �� .��5�      W� -   5        + g�Name$+ WindowAnimation��5�   &   $ Window��5�   &   $ Opacity�5�   !    0.05�   !    1.06,   $ 	00:00:0.6D�65   W� 5�      -   5        $+ HeaderAnimation��5�   &    05�   &    1166/   $ 	00:00:0.8D�68   , g� 	BeginTime, 0:0:0.65�   &   $ HeaderBorder��5�   !   $ Height�5�   !   - W� EasingFunction- 5�      0  *System.Windows.Media.Animation.QuarticEase  5�      7  1System.Windows.Media.Animation.EasingFunctionBase.   
EasingMode$. 	EaseInOut=�6*   5�      W� 5�      -   5        $+ HeaderTextAnimation��5�   &   $ HeaderTextBlock��5�   &   $ Opacity�5�   !   , 	00:00:0.85�   &    0.05�   !    1.06,   $ 	00:00:0.4D�65   W� 5�      -   5        $+ CloseButtonAnimation��5�   &   $ CloseButton��5�   &   $ Opacity�5�   !   , 00:00:015�   &    0.05�   !    1.06,   $ 	00:00:0.5D�65   W� 5�      -   5        $+ SearchTextBoxAnimation��5�   &   $ SearchTextBox��5�   &   $ Opacity�5�   !   , 
00:00:01.35�   &    0.05�   !    1.06,   $ 	00:00:0.4D�65   W� 5�      -   5        $+ ScrollViewerAnimation��5�   &   $ ScrollViewer��5�   &   $ Opacity�5�   !   , 
00:00:01.85�   &    0.05�   !    1.06,   $ 	00:00:0.4D�65   W� 5�      -   5        $+ CreateButtonAnimation��5�   &   $ CreateButton��5�   &   $ Opacity�5�   &    05�   &    15�   &   $ 0:0:0.3D�5�   &   , 0:0:2.55�   &   5�      5�      5�      .��5      � -	   5        .+�5  
   ]� .+�5     �� ���#eef2f5$
��auto��5     .+�5     �� -
   5        $ HeaderBorder��5  ,   
�������$��0��5      5       5     $ #e4e5e6��6+   $ 8Q�5	  +   $	 -90Q�5
  +   $ Performance=�5  +   ._�5     �� $��20q�6!   .+�5     � $��0 0 0 10q�6   ! 5     �� 5  "   $
��auto �63   �� 5  "   $��* �63   " 5     �� 5  "   .+�5     �� -   5        $# HeaderTextBlock��5  (   / J� Opacity$/ 0Q�5  (   $��0��5  (   $��0��5  (   $��Заметки��5  (   $
��Left=�5  (   $��26(�5   (   $��Arial Rounded MT Bold)�5!  (   ���#7b7b7b$
��Bold"�5"  =   �� 5$     $��0��6)   $��1��5%  %   $  
Horizontal=�5&  %   $��Right=�5'  %   .+�5)  "   �� -   5        $& CloseButton��5)  )   $' 
Выход��5*  )   $��34��5+  )   $/ 0Q�5,  )   $��34��5-  )   $
 Hand��5/  )   $��Right=�50  )   $��18(�51  )   $��0 0 0 0q�52  )   $��0 2 0 0q�53  )   $��Center=�54  )   
������ )  #HandyControl.Controls.BorderElement0   CornerRadius$0 16��56  )   $��Stretch=�57  )   ���#b2b2b4$	��✖��59  )   #��[ 5:  )   $��Arial Black)�5;  )   $��Normal"�5<  )   $��Normal$�6=   6P   5>     5?     %  HandyControl.Controls.SearchBar  5A     -   5        $��SearchTextBox��5D  '   $
��14 0q�5A  '   $3' -Поиск по ключевым словам��5B  '   $/ 0Q�5C  '   $��15(�5F  '   $0 12��5G  '   $��0q�5H  '   ���#eff0f2���#5f5f5f'  !HandyControl.Controls.InfoElement1   Placeholder$1 
Поиск��5K  '   2   	Necessary$
2 True��5L  '   $��32��5M  '     SearchBarExtend#��[ 5N  '   $��Yu Gothic UI Semibold)�5P  '   3   Command3 5Q  '   �� *SearchNotesCommand+4   CommandParameter4 5R  '   �� 5 �� ElementName$5 SearchTextBox��$
$ Text�5S     5T     �� 5V     -   5        $��ScrollViewer��5W     $
��auto��5V     $	��490��5X     $/ 0Q�5Y     $
��Auto=�5Z     $
��True��5[     .��5]     �� -   5        $��
NotesPanel��5`  #   #��[  5^  #   $��
20 20 20 0q�5_  #   $
��auto��5a  #   $	��483��5b  #   ��5]  #   �� *Notes+5e     5f     5g     5h     �� 5k  
   -   5        $& CreateButton��5m     $/ 0Q�5k     $#' Создать заметку��5l     $��Создать��5n     $��16(�5o     $��0q�5p     ���#6072ee
�������$��38��5t     $0 20��5u     $��	0,0,20,20q�5v     $��0q�5w     $
 Hand��5x     $��Right=�5y     $��Bottom=�5z     6 J� RenderTransformOrigin$6 0.244,-0.429&�5{     $��Center=�5|     $
��Bold"�5}     $	��100��5~     $��Arial Rounded MT Bold)�5      5�       5�     $ #6072ee��6#   $ 8Q�5�  #   7   Opacity$	7 0.4Q�5�  #   $ 5Q�5�  #   $	 -90Q�5�  #   $ Performance=�5�  #   5�     5�     5�     
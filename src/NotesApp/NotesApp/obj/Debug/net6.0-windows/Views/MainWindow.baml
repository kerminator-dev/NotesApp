   M S B A M L   `   `   `  ����C  ?NotesApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:NotesApp.ViewModelsNotesApp.ViewModels  5   	       NotesApp.Views.MainWindow   5   	   S OHandyControl, Version=3.3.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8
viewModels!clr-namespace:NotesApp.ViewModels     5   	   -   5        $��Window��5   	     � Title$  Notes��5	   	   $	��600��5
   	   $	��350��5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency$
 True��5   	    � WindowStartupLocation$ Manual=�5   	    � Topmost$
 True��5   	    � 	Resources 5         NoteTemplate �� DataType'   !NotesApp.ViewModels.NoteViewModel �� Triggers	 :� RoutedEvent
 W�Name �� TargetProperty W� From	 W� To g� Duration	 �� To �� 
TargetName g� FillBehavior ��Name � Cursor �� CornerRadius �� Padding � UseLayoutRounding �� BitmapScalingMode J� SnapsToDevicePixels �� ClearTypeHint J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   Color   
BlurRadius   	Direction   RenderingBias   ShadowDepth  �� Orientation! � ColumnDefinitions" � RowDefinitions# ��Name$ �� Path% �� Mode& ��Name' � ToolTip  ButtonCustom( �� RelativeSource) �� AncestorType-   'NotesApp.ViewModels.MainWindowViewModel��%�  &	        7  �� 5   
   "  6,    5      :� 5      $	 Loaded��6   .[�5      �� .��5      �� .��5      W� $
 OpacityAnimation��5   &   $ Opacity�5   !    0.05    !    1.06,   $ 	00:00:0.4D�65   5!      5"      5#      :� 5%      $	 
MouseEnter��6   .[�5'      �� .��5(      �� .��5)      ��  #6072ee6-   $ ControlBorder��5*   %   $1 +(Border.Background).(SolidColorBrush.Color)�5+   %   $ HoldEnd=�5,   %   $ 0:0:0D�5-   %   �� 5.       #dedefb6-   $ ControlBorder��5/   %   $ (Effect).(Color)�50   %   $ HoldEnd=�51   %   $ 0:0:0D�52   %   �� 53      	 White6-   $ TitleTextBlock��54   %   $4 .(TextBlock.Foreground).(SolidColorBrush.Color)�55   %   $ HoldEnd=�56   %   $ 0:0:0D�57   %   �� 58      	 White6-   $ ContentTextBlock��59   %   $4 .(TextBlock.Foreground).(SolidColorBrush.Color)�5:   %   $ HoldEnd=�5;   %   $ 0:0:0D�5<   %   �� 5=      	 White6-   $ CreatedTextBlock��5>   %   $4 .(TextBlock.Foreground).(SolidColorBrush.Color)�5?   %   $ HoldEnd=�5@   %   $ 0:0:0D�5A   %   5B      5C      5D      :� 5E      $	 
MouseLeave��6   .[�5G      �� .��5I      �� .��5K      �� 	 White6-   $ ControlBorder��5L   %   $1 +(Border.Background).(SolidColorBrush.Color)�5M   %   $ HoldEnd=�5N   %   $ 0:0:0D�5O   %   �� 5P       #e4e5e66-   $ ControlBorder��5Q   %   $ (Effect).(Color)�5R   %   $ HoldEnd=�5S   %   $ 0:0:0D�5T   %   �� 5U       #8c8c8c6-   $ 0:0:0D�5V   %   $ TitleTextBlock��5W   %   $4 .(TextBlock.Foreground).(SolidColorBrush.Color)�5X   %   $ HoldEnd=�5Y   %   �� 5Z       #8C8C8C6-   $ ContentTextBlock��5[   %   $4 .(TextBlock.Foreground).(SolidColorBrush.Color)�5\   %   $ HoldEnd=�5]   %   $ 0:0:0D�5^   %   �� 5_       #BEBEBF6-   $ CreatedTextBlock��5`   %   $4 .(TextBlock.Foreground).(SolidColorBrush.Color)�5a   %   $ HoldEnd=�5b   %   $ 0:0:0D�5c   %   5d      5e      5f      .R�5h      �� $ ControlBorder��6   $
 Hand��5i      
�������
�������$ 8��5l      $ 10q�5m      $��0 0 0 20q�5n      $
 True��5o      $ NearestNeighbor=�5p      $
 True��5q      $ Enabled=�5r       5t        5u      DropShadowEffect��$ #e4e5e6��5v      $ 8Q�5w      $	 -90Q�5x      $ Performance=�5y      $ 5Q�5z      ._�5|      ]� $��Stretch=�6   .+�5}      �� $  Vertical=�6!   $��Stretch=�5~      .+�5      � ! 5�      �� 5�   "   �� 5�   "   $
��auto �63   " 5�      �� 5�   "   $
��auto �60   .+�5�      �� $# TitleTextBlock��5�       $��0��5�   (   $��0��65   
������ ���#8c8c8c$
��auto��5�       $	��Top=�5�       $��17(�5�       $��Arial Rounded MT Bold)�5�       $��0 0 0 4q�5�       $
��Wrap=�5�       $��Normal"�5�       ��5�       �� $$ 
ShortTitle�$% OneTime=�5�       �� 5�      $& DeleteButton��6%   $��22��5�      $#' Удалить заметку��5�      $��22��5�      $��0��5�      $��1��5�      $
 Hand��5�      $��Right=�5�      $��12(�5�      $��Center=�5�      $��Center=�5�      
������ $y�Visible=�5�      $��4 0 0 0q�5�      
�������$	��✖��5�      8��  $��Arial)�5�      $��Normal"�5�      $��Normal$�61   $	��Top=�5�      ��5�      �� *ID+��5�      �� ( �� *FindAncestor+")  $$ DeleteCommand�5�      5�      �� 5�      $# ContentTextBlock��5�      
������ ���#909090$��12(�5�      $
��auto��5�   M   $
��Left=�5�      $��Yu Gothic UI Semibold)�5�      $
��Wrap=�5�      ��5�      �� $$ ShortContent�$% OneTime=�5�      �� 5�      $# CreatedTextBlock��5�      $��0 5 0 0q�5�   $   
������ ���	#FFBEBEBF$��Arial Rounded MT Bold)�5�      $��11(�5�      $��Bottom=�5�      $��Right=�5�      ��5�      �� $$ ShortCreated�$% OneTime=�5�      5�      5�      5�      5�      5�      * � Triggers* 5�      :� 5�   
   $	 Window.Loaded��6   .[�5�      �� .��5�      �� .��5�      W� -   5        + g�Name$+ WindowAnimation��5�   &   $ Window��5�   &   $ Opacity�5�   !    0.05�   !    1.06,   $ 	00:00:0.6D�65   W� 5�      -   5        $+ HeaderAnimation��5�   &    05�   &    1166/   $ 	00:00:0.8D�68   , g� 	BeginTime, 0:0:0.65�   &   $ HeaderBorder��5�   !   $ Height�5�   !   - W� EasingFunction- 5�      0  *System.Windows.Media.Animation.QuarticEase  5�      7  1System.Windows.Media.Animation.EasingFunctionBase.   
EasingMode$. 	EaseInOut=�6*   5�      W� 5�      -   5        $+ HeaderTextAnimation��5�   &   $ HeaderTextBlock��5�   &   $ Opacity�5�   !   , 	00:00:0.85�   &    0.05�   !    1.06,   $ 	00:00:0.4D�65   W� 5�      -   5        $+ CloseButtonAnimation��5�   &   $ CloseButton��5�   &   $ Opacity�5�   !   , 00:00:015�   &    0.05�   !    1.06,   $ 	00:00:0.5D�65   W� 5�      -   5        $+ SearchTextBoxAnimation��5�   &   $ SearchTextBox��5�   &   $ Opacity�5�   !   , 
00:00:01.35�   &    0.05�   !    1.06,   $ 	00:00:0.4D�65   W� 5�      -   5        $+ ScrollViewerAnimation��5�   &   $ ScrollViewer��5�   &   $ Opacity�5�   !   , 
00:00:01.85�   &    0.05�   !    1.06,   $ 	00:00:0.4D�65   W� 5�      -   5        $+ CreateButtonAnimation��5�   &   $ CreateButton��5�   &   $ Opacity�5�   &    05�   &    15�   &   $ 0:0:0.3D�5�   &   , 0:0:2.55�   &   5�      5�      5�      .��5     � -	   5        .+�5  
   ]� .+�5     �� ���#eef2f5$
��auto��5     .+�5     �� -
   5        $ HeaderBorder��5  ,   
�������$��0��5      5	       5
     $ #e4e5e6��6+   $ 8Q�5  +   $	 -90Q�5  +   $ Performance=�5  +   ._�5     �� $��20q�6!   .+�5     � $��0 0 0 10q�6   ! 5     �� 5  "   $
��auto �63   �� 5  "   $��* �63   " 5     �� 5  "   .+�5     �� -   5        $# HeaderTextBlock��5  (   / J� Opacity$/ 0Q�5  (   $��0��5  (   $��0��5  (   $��Заметки��5   (   $
��Left=�5!  (   $��26(�5"  (   $��Arial Rounded MT Bold)�5#  (   ���#7b7b7b$
��Bold"�5$  =   �� 5&     $��0��6)   $��1��5'  %   $  
Horizontal=�5(  %   $��Right=�5)  %   .+�5+  "   �� -   5        $& CloseButton��5+  )   $' 
Выход��5-  )   $��34��5.  )   $/ 0Q�5/  )   $��34��50  )   $
 Hand��52  )   $��Right=�53  )   $��18(�54  )   $��0 0 0 0q�55  )   $��0 2 0 0q�56  )   $��Center=�57  )   
������ )  #HandyControl.Controls.BorderElement0   CornerRadius$0 16��59  )   $��Stretch=�5:  )   ���#b2b2b4$	��✖��5<  )   #��[ 5=  )   $��Arial Black)�5>  )   $��Normal"�5?  )   $��Normal$�6=   ��5,  )   �� *CloseWindowCommand+5?  =   5A     5B     %  HandyControl.Controls.SearchBar  5D     -   5        $��SearchTextBox��5G  '   $
��14 0q�5D  '   $3' -Поиск по ключевым словам��5E  '   $/ 0Q�5F  '   $��15(�5I  '   $0 12��5J  '   $��0q�5K  '   ���#eff0f2���#5f5f5f'  !HandyControl.Controls.InfoElement1   Placeholder$1 
Поиск��5N  '   2   	Necessary$
2 True��5O  '   $��32��5P  '     SearchBarExtend#��[ 5Q  '   $��Yu Gothic UI Semibold)�5R  '   3   Command3 5S  '   �� *SearchNotesCommand+4   CommandParameter4 5T  '   �� 5 �� ElementName$5 SearchTextBox��$
$ Text�5U     5V     �� 5X     -   5        $��ScrollViewer��5Y     $
��auto��5X     $	��490��5Z     $/ 0Q�5[     $
��Auto=�5\     $
��True��5]     .��5_     �� -   5        $��
NotesPanel��5b  #   #��[  5`  #   $��
20 20 20 0q�5a  #   $
��auto��5c  #   $	��483��5d  #   ��5_  #   �� *Notes+5g     5h     5i     5j     �� 5m  
   -   5        $& CreateButton��5o     $/ 0Q�5m     $#' Создать заметку��5n     $��Создать��5q     $��16(�5r     $��0q�5s     ���#6072ee
�������$��38��5w     $0 20��5x     $��	0,0,20,20q�5y     $��0q�5z     $
 Hand��5{     $��Right=�5|     $��Bottom=�5}     6 J� RenderTransformOrigin$6 0.244,-0.429&�5~     $��Center=�5     $
��Bold"�5�     $	��100��5�     $��Arial Rounded MT Bold)�5�     ��5p     �� *CreateCommand+ 5�       5�     $ #6072ee��6#   $ 8Q�5�  #   7   Opacity$	7 0.4Q�5�  #   $ 5Q�5�  #   $	 -90Q�5�  #   $ Performance=�5�  #   5�     5�     5�     
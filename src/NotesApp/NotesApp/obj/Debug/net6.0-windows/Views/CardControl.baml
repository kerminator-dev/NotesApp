   M S B A M L   `   `   `  ����  NotesApp     NotesApp.Views.CardControl   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5        $��Card_UserControl��5      $��0��5      $	��200��5      $
��1600��5	      $	��450��5
      $��0q�5      $
��auto��5      $
��auto��5        � UseLayoutRounding$
  True��5      $��0 0 0 20q�5       J� Opacity$ 0Q�5       � Triggers 5      :� 5   
    :� RoutedEvent$ UserControl.Loaded��6   .[�5      �� .��5      �� .��5      W� -   5         W�Name$ OpacityAnimation��5   &    �� 
TargetName$ Card_UserControl��5   &    �� TargetProperty$ Opacity�5   !    W� From 0.05   !   	 W� To 1.06,   	 g� Duration$	 	00:00:0.4D�65   5      5      5      :� 5    
   $ UserControl.MouseEnter��6   .[�5"      �� .��5#      �� .��5$      �� 	
 �� To
 #6072ee6%   $ ControlBorder��5%   %   $1 +(Border.Background).(SolidColorBrush.Color)�5&   %    g� FillBehavior$ HoldEnd=�5'   %   $	 0:0:0D�5(   %   �� 5)      
 #dedefb6%   $ ControlBorder��5*   %   $ (Effect).(Color)�5+   %   $ HoldEnd=�5,   %   $	 0:0:0D�5-   %   �� 5.      	
 White6%   $ TitleTextBlock��5/   %   $4 .(TextBlock.Foreground).(SolidColorBrush.Color)�50   %   $ HoldEnd=�51   %   $	 0:0:0D�52   %   54      55      56      :� 57   
   $ UserControl.MouseLeave��6   .[�59      �� .��5;      �� .��5=      �� 	
 White6%   $ ControlBorder��5>   %   $1 +(Border.Background).(SolidColorBrush.Color)�5?   %   $ HoldEnd=�5@   %   $	 0:0:0D�5A   %   �� 5B      
 #e4e5e66%   $ ControlBorder��5C   %   $ (Effect).(Color)�5D   %   $ HoldEnd=�5E   %   $	 0:0:0D�5F   %   �� 5G      
 #8c8c8c6%   $	 0:0:0D�5H   %   $ TitleTextBlock��5I   %   $4 .(TextBlock.Foreground).(SolidColorBrush.Color)�5J   %   $ HoldEnd=�5K   %   5M      5N      5O      .��5R      �� -   5         ��Name$ ControlBorder��5R       � Cursor$
 Hand��5S      
�������
������� �� CornerRadius$ 8��5V       �� Padding$ 10q�5W      $
  True��5Z       �� BitmapScalingMode$ NearestNeighbor=�5[       J� SnapsToDevicePixels$
 True��5\       �� ClearTypeHint$ Enabled=�5]       J� Effect 5_   
   3  -System.Windows.Media.Effects.DropShadowEffect  5`      -   5        DropShadowEffect��   Color$ #e4e5e6��5a         
BlurRadius$ 8Q�5b         	Direction$	 -90Q�5c         RenderingBias$ Performance=�5d         ShadowDepth$ 5Q�5e      ._�5g   
   ]� $��Stretch=�6   .+�5h      ��  �� Orientation$ Vertical=�6   $��Stretch=�5i      .+�5j      �  � ColumnDefinitions 5k      �� 5l      �� 5m      $
��auto �6+    � RowDefinitions 5o      �� 5p      $
��auto �6(   .+�5s      �� -   5         ��Name$ TitleTextBlock��5u       $��0��5s       $��0��6-   
������ ���#8c8c8c$
��auto��5w       $	��Top=�5x       $��17(�5y       $��Arial Rounded MT Bold)�5z       $��0 0 0 4q�5{       $
��Wrap=�5|       $��Normal"�5}       ��5v       ��  �� Path$ 
ShortTitle� �� Mode$ OneTime=�5}       �� 5      -   5         ��Name$ DeleteButton��5      $��22��5�        � ToolTip$#  Удалить заметку��5�      $��22��5�      $��0��5�      $��1��5�      $
 Hand��5�      $��Right=�5�      $��12(�5�      $��Center=�5�      $��Center=�5�      
������ $y�Visible=�5�      $��4 0 0 0q�5�      
�������$	��✖��5�         ButtonCustom#��[  5�      $��Arial)�5�      $��Normal"�5�      $��Normal$�61   $	��Top=�5�      65   5�      �� 5�      -   5        $ ContentTextBlock��5�      
������ ���#909090$��12(�5�      $
��auto��5�   M   $
��Left=�5�      $��Yu Gothic UI Semibold)�5�      $
��Wrap=�5�      ��5�      �� $ ShortContent�$ OneTime=�5�      �� 5�      -   5        $ CreatedTextBlock��5�      $��0 5 0 0q�5�      
������ ���	#FFBEBEBF$��Arial Rounded MT Bold)�5�      $��11(�5�      $��Bottom=�5�      $��Right=�5�      ��5�      �� $ ShortCreated�$ OneTime=�5�      5�      5�      5�      5�      
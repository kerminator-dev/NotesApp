   M S B A M L   `   `   `  ����C  ?NotesApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:NotesApp.ViewModelsNotesApp.ViewModels  5   <   (    "NotesApp.Views.NotificationControl   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   S OHandyControl, Version=3.3.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5   	   1	viewmodel!clr-namespace:NotesApp.ViewModels  6<   :d2http://schemas.microsoft.com/expression/blend/2008  6p   -   5        $��Notification��5   	   
�������  �� CornerRadius$  6��5   	      BorderBrush#���   5   	   $	��280��5   	   $	��200��5	   	   $��80��5
   	   $��20q�5   	    � Triggers 5      :� 5   
    :� RoutedEvent$ Control.Loaded��6   .[�5      �� .��5      �� .��5      W�  �� 
TargetName$ Notification��6&    �� TargetProperty$ Opacity�5   !    W� From 0.05   !   	 W� To 1.06,    g� Duration$ 	00:00:0.4D�65   W� 5      $ TitleTextBlock��6&    g� 	BeginTime 0:0:0.25   &   $ Opacity�5   !    0.05   !    1.06,   $ 	00:00:0.3D�65   W� 5      $ Divider��6&    0:0:0.45   &   $ Opacity�5   !    0.05   !    1.06,   $ 	00:00:0.3D�65   W� 5"      $ CloseButton��6&    0:0:0.65#   &   $ Opacity�5$   %    0.05%   %    1.060   $ 	00:00:0.4D�69   5'      5(      5)      ._�5,      � $��Stretch=�6   	 � ColumnDefinitions	 5-   
   �� 5.      
 � RowDefinitions
 50   
   �� 51      $
��auto �6   �� 52      .+�55   
   �� -   5         ��Name$ TitleTextBlock��59      $��20 20 20 16q�55      $��0��6)   $��0��56       �� TextAlignment$ Center=�57      $��Center=�5:      $	��Top=�5;      ���#8c8c8c$
��auto��5=      $
��Wrap=�5>      $��16(�5?      $��Arial Rounded MT Bold)�5@       J� Opacity$ 0Q�5A      ��58      �� *Title+ �� Mode$ OneTime=�5D      � 5E   
   $��0��6   $��1��5F      
 5G      �� 5H      $
��auto �6    �� 5I      	 5K      �� 5L      .+�5O      #  HandyControl.Controls.Divider  -   5          Name$ Divider��5O   %   $ 0Q�6   $��0��67   $��0��6G      LineStrokeThickness$ 2Q�6T   $��Stretch=�6l   $
��20 0q�6�   �� 5P      -   5         ��Name$ CloseButton��5R      $��0��5P      $��1��6%   $	��0 5q�5Q      $��15(�5T      $��0q�5U      
������ ���#6072ee$��32��5X      )  #HandyControl.Controls.BorderElement   CornerRadius$ 10��5Y      $��0q�5Z       � Cursor$
 Hand��5[      $��Center=�5\      $ 0Q�5]      $��Bottom=�5^       J� RenderTransformOrigin$ 0.244,-0.429&�5_      $��Center=�5`      $
��Bold"�5a      $	��120��5b      $��Arial Rounded MT Bold)�5c      $$��hc:ControlCommands.CloseWindow��5d      ��5S      �� *
ButtonText+$ OneTime=���5e      ��  �� RelativeSource �� *Self+5g      5h      5i      
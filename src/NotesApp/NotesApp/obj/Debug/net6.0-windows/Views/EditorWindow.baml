   M S B A M L   `   `   `  ����C  ?NotesApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:NotesApp.PropertiesNotesApp.Properties  5   	   9!clr-namespace:NotesApp.ViewModelsNotesApp.ViewModels  5   	   9!clr-namespace:NotesApp.ConvertersNotesApp.Converters  6=   !    NotesApp.Views.EditorWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   S OHandyControl, Version=3.3.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5   	   2
properties!clr-namespace:NotesApp.Properties  5   	   1	viewmodel!clr-namespace:NotesApp.ViewModels  5   	   2
converters!clr-namespace:NotesApp.Converters  6=   -   5          �Name$  Window��5   	    � Title$ EditorWindow��5	   	   $	��600��5
   	   $	��350��5   	   $	��594��5   	   $	��344��5   	    � 
ResizeMode$ CanResizeWithGrip=�5   	    � WindowStyle$
 None=�5   	   $��0q�5   	    � AllowsTransparency$
 True��5   	    � Topmost$
 True��5   	   
 � Top 5   	   �� "  NotesApp.Properties.Settings   Default �� Source# Z 	 �� Path$	 EditorWindowTop�
 �� Mode$
 TwoWay=� � Left 5   	   �� # Z $	 EditorWindowLeft�$
 TwoWay=�'  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      CaptionHeight$ 0Q�6    � 	Resources 5      1   +NotesApp.Converters.InverseBooleanConverter   InverseBooleanConverter=   7NotesApp.Converters.InverseBooleanToVisibilityConverter ' #InverseBooleanToVisibilityConverter��%:   &	        &	        5   
   6-     5   
   69   5        � Triggers 5"      :� 5#   
    :� RoutedEvent$ Window.Loaded��6   .[�5$      �� .��5%      �� .��5(      W�  �� 
TargetName$ Window��6&    �� TargetProperty$ Opacity�5*   !    W� From 0.05+   !   	 W� To 1.06,    g� Duration$ 	00:00:0.4D�65   W� 5/       06&    506/   $ 
00:00:0.63D�67   $ HeaderPanel��50   !   $ Height�51   !    W� EasingFunction 52      0  *System.Windows.Media.Animation.QuarticEase  53      7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode$ 	EaseInOut=�6*   56      W� 58      $ 
BackButton��6&   $ Opacity�5:   !    g� 	BeginTime 	00:00:0.45;   !    0.05<   !    1.06,   $ 	00:00:0.5D�65   W� 5?      $ 
SaveButton��6&   $ Opacity�5A   !    
00:00:00.65B   &    0.05C   !    1.06,   $ 	00:00:0.5D�65   W� 5F      $ TitleTextBox��6&   $ Opacity�5H   !    
00:00:00.85I   &    0.05J   !    1.06,   $ 	00:00:0.5D�65   W� 5L      $ DateTextBlock��6&   $ Opacity�5N   !    00:00:015O   !    0.05P   !    1.06,   $ 	00:00:0.5D�65   W� 5S      $ ContentTextBox��6&   $ Opacity�5U   !    
00:00:01.35V   !    0.05W   !    1.06,   $ 	00:00:0.5D�65   W� 5[       06&    386/   $ 	00:00:0.4D�67    
00:00:02.35\   !   $ FooterPanel��5]   !   $ Height�5^   !    5a        5b      $ 	EaseInOut=�6*   5e      W� 5g      $ SymbolsCountTextBlock��6&   $ Opacity�5i   !    
00:00:01.75j   !    0.05k   !    1.06,   $ 	00:00:0.4D�65   W� 5n      $ FontSizeTextBlock��6&   $ Opacity�5p   !    00:00:025q   !    0.05r   !    1.06,   $ 	00:00:0.4D�65   W� 5u      $ 
FontSlider��6&   $ Opacity�5w   !    00:00:025x   !    0.05y   !    1.06,   $ 	00:00:0.4D�65   5{      5|      5}      .��5�      � ���#eef2f5 � ColumnDefinitions 5�   
   �� 5�       � RowDefinitions 5�   
   �� 5�      -   5         �Name$ Header��5�      $
��auto �6*   �� 5�      -   5        $
 Main��5�      �� 5�      -   5        $ Footer��5�      $
��auto �6*   .+�5�   
   �� -   5        $��0��5�      $��0��6)   .��5�      ]� -   5         ]�Name$ HeaderPanel��5�      .+�5�      �� 
������� �� Padding$ 20 10 20 10q�6,    J� Effect 5�      3  -System.Windows.Media.Effects.DropShadowEffect  5�         Color$ #e4e5e6��6+       
BlurRadius$  8Q�5�   +   !   	Direction$	! -90Q�5�   +   "   RenderingBias$" Performance=�5�   +   ._�5�      �  5�      �� 5�      �� 5�      $
��auto �6/    5�      �� 5�      .+�5�      �� -   5        # ��Name$# 
BackButton��5�   !   $��0��66   $ J� Opacity$$ 0Q�5�   !   % � ToolTip$(% "Вернуться к списку��5�   !   $��0��5�   !   $��30��5�   !   $
��Left=�5�   !   & � Cursor$
& Hand��5�   !   $��28(�5�   !   $��Center=�5�   !   
������ )  #HandyControl.Controls.BorderElement'   CornerRadius$' 16��5�   !   ���	#FFBEBEBF$	��⬅��5�   !   $
��Left=�5�   !     ButtonCustom#��[ 5�   !   $��Arial Black)�5�   !   $��Normal"�5�   !   65   �� 5�      -   5        $# 
SaveButton��5�   !   $��0��66   $��0 5 0 0q�5�   $   $+% %Сохранить изменения��5�   $   $$ 0Q�5�   $   $��1��5�   $   $��30��5�   $   $��30��5�   $   $
& Hand��5�   $   $��Right=�5�   $   $��20(�5�   $   
������ $' 16��5�   $   $	��✔��5�   $   $��Arial)�5�   $   $��Normal"�5�   $   $��Normal$�5�   $   $��Stretch=�5�   $   {�5�   $   �� *	NoteSaved+( �� 	Converter#( [  ) �� UpdateSourceTrigger$) Default=���5�   $   �� $	 SaveCommand���5�      �� 5�   "   * �� 
TargetType"* ��6(   .�5�   &   �� + �� Property+ � ��, �� Value, �#5f72ea6D   �� 5�   &   + � ��$, 0q�6H   5�   #   5�      5�      5�      5�      5�      ]� 5�   
   $��0��6   $��1��6%   .+�5�      �  5�      �� 5�       5�      �� 5�      $
��auto �6$   �� 5�      $
��auto �6$   �� 5�      $
��auto �6$   �� 5�      .+�5�      �� 
���  ��$��12(�5�      ��5�      �� *ErrorMessage+y�5�      �� *
HasError+#( [ 5�      �� 5�      d.DesignOpacity1  5�      -	   5        - ��Name$- TitleTextBox��5�      . �� SelectionBrush. �#5f72ea$$ 0Q�5�      $��0��5�      $��1��6*   $��Disabled=�5�      
������ $& IBeam��5�      $��0q�5�      / �� TextWrapping$
/ Wrap=�5�      $��20 20 20 10q�5�      $��18(�5�      ���#8c8c8c$
��Bold"�5�      $��Arial Rounded MT Bold)�5�      0 �� 	MaxLength$	0 255��5�      ��5�      �� $	 Title�$
 TwoWay=�$) PropertyChanged=�5�      �� 5�      -
   5        1 ��Name$1 DateTextBlock��5�      $% Дата создания��5�      $��0��5�      $��2��6,   $$ 0Q�5�      2 �� Padding$2 	20 0 20 0q�5�      $��24.07.2021, 14:40:45��5�      $��12(�5�      $��Arial Rounded MT Bold)�5�      ���	#FFBEBEBF$��0 2 0 10q�5�      �� 5      -   5        $- ContentTextBox��5     $��0��5     $��3��6*   $$ 0Q�5     
������ $��Arial Rounded MT Bold)�5     $0 102400��5     $��	20 0 20 0q�5     $��14(�5     $��0q�5	     $
��True��5
     3 � UseLayoutRounding$3 False��5     "4 �� VerticalScrollBarVisibility$4 Visible=�5     ���#8c8c8c$& IBeam��5     5 �� AcceptsReturn$
5 True��5     $	��Top=�5     $
��Auto=�5     $
��Auto=�5     $
/ Wrap=�5     $��Stretch=�5     . �#5f72ea$��Stretch=�5     ��5      �� $	 Content�$
 TwoWay=�$) PropertyChanged=�5     5     5     �� 5  
   -   5        6 ��Name$6 FooterPanel��5     $��0��66   
�������$��0��6U   $��2��6e   $ 20 10q�6r   ._�5     � $��Stretch=�6   $��Stretch=�6/    5     �� 5     $
��auto �6'   �� 5      5!     �� 5"     .+�5%     �� -   5        $��SymbolsCountTextBlock��5%  9   $��0��6   $��0��6,   $$ 0Q�5'     $��12(�5(     ���#8c8c8c$��Arial Rounded MT Bold)�5*     $��Center=�5+     ��5&     �� $	 Content.Length�$
 OneWay=�5+     �� 5.     $��1��6   7 �� Orientation$7 
Horizontal=�5/     $��Right=�50     .+�51     �� -   5        $��FontSizeTextBlock��53      $��Размер:��51      $$ 0Q�52      $��1��55      $��12(�56      ���#8c8c8c$��Arial Rounded MT Bold)�58      $��Center=�59      �� 5:     -   5        8 ��Name$8 
FontSlider��5:     $$ 0Q�5;     $��10 0 0 0q�5=     &	   HandyControl.Controls.TipElement9 	  
Visibility$9 Visible=�5>     : 	  	Placement$	: Top=�5?     $��Center=�5@     $��Right=�5A     $
& Hand��5B     $	��132��5C     ; � Maximum$; 26Q�5D     < � Minimum$< 10Q�5E     5G     5J     5K     5L     5M     5N     
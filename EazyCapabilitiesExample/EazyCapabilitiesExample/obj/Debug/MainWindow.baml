   M S B A M L   `   `   `  ����R  NEazyCapabilitiesExample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:EazyCapabilitiesExampleEazyCapabilitiesExample  5   	   U/clr-namespace:EazyCapabilitiesExample.ViewModel!EazyCapabilitiesExample.ViewModel  5   	   (    "EazyCapabilitiesExample.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:EazyCapabilitiesExample     5   	   >vm/clr-namespace:EazyCapabilitiesExample.ViewModel     5   	   -   5          �Name$  
mainWindow��5	       � Title$ 
MainWindow��6	    � DataContext 5      5  /EazyCapabilitiesExample.ViewModel.MainViewModel  5   
    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$
 Save��5      6(    � 	Resources 5       �� MergedDictionaries �� Source9  3EazyCapabilitiesExample.ViewModel.DateTimeConverter   
myDateTime �� 
TargetType  baseTextBlock	 �� BasedOn�� 5   
    5      �� 5      $  Resources/SomeBrushes.xaml?�6%   �� 5      $ Resources/Styles.xaml?�6%   �� 5      $ Resources/Over.xaml?�6%   %M   &	        '��      7    5      6#   �� 5      " ��6   8	   6+   5      
 � Triggers
 5      :� 5   
    :� RoutedEvent$ Page.Loaded��6   .[�5       �� -   5         ��Name$) #backgroundAnimationsBeginStoryboard��5       .��5!      �� .��5"      ��  �� 
TargetName$ 	mainPanel��5#       �� TargetProperty$~ x(DockPanel.Background).(DrawingBrush.Drawing).(DrawingGroup.Children)[0].(GeometryDrawing.Brush).(SolidColorBrush.Color)�5$       �� From$ 	LightGrayX�5%      	 �� To$ DarkGrayX�6    g� Duration$ 0:0:50D�6,    g� RepeatBehavior$ Forever��6>    g� AutoReverse . 5&      W� 5'      $ 	mainPanel��5(      $M G(DockPanel.Background).(DrawingBrush.Transform).(RotateTransform.Angle)�5)       W� From$ 0X�5*      	 W� To$	 360X�6   $ 0:5:00D�6   $ Forever��61    . 5+      W� 5,      $ 	mainPanel��5-      $� }(DockPanel.Background).(DrawingBrush.Drawing).(DrawingGroup.Children)[1].(GeometryDrawing.Geometry).(EllipseGeometry.RadiusX)�5.      $	 0.1X�5/      $
 0.25X�6   $ 0:0:5D�6"   $ Forever��63    . 50      ,� 51      $ 	mainPanel��52      $� |(DockPanel.Background).(DrawingBrush.Drawing).(DrawingGroup.Children)[2].(GeometryDrawing.Geometry).(EllipseGeometry.Center)�53       ,� From$ -0.25, -0.25X�54      	 ,� To$ 	1.25,1.25X�6!   $ 0:0:10D�60   $ Forever��6B    . 55      56      57      58      .��5:      ]� -   5         ]�Name$ 	mainPanel��5:        MainBackgroundBrush#��[ 6#   .+�5;   
   o� $	��Top=�6   .@�5<      m� $
��File��6   .@�5=      m� $
��Save��6    m� Command$
 Save��6)   m� 5>      -   5        $
��Exit��5>      6)   5?      5@      �� 5A   
   $��Right=�6   $��Right=�6(   $��Stretch=�6D   ._�5B      9�  9� ExpandDirection$ Right=�6   ��5C      �� 5D        BorderTriggerStyle#��[ 6     myBackgroundBrush#��[ 6I   ._�5E      ��   textBoxStyle#��[ 6$   $(��"Добавление и поиск��6J   5F      .��5H      �� 
�������$��3q�6,   $��3q�6@    �� CornerRadius$ 20��6K   ���	#4CFFFFFF._�5I      �� $	��150��6!   $��10,20,10,10q�6-   .+�5J      ]� $��24��6$   .+�5K      �� $
��Left=�6-     
SearchIcon#��[ 6C   
�������  IconContent#��[ 6{   �� 5L      ��6&   �� *
SearchText+ �� UpdateSourceTrigger$ PropertyChanged=�5M      �� 5N        
BaseButton#��[ 5P      $��Добавить��5Q      
�������$��Center=�5S      $��10q�5T      $��Consolas)�5U      ��5O      �� *AddEmployee+5U      5V      5W      5X      5Y      � 5[   
   $��Stretch=�6    � RowDefinitions 5\      �� 5]      $��50 �6    �� 5^      �� 5_      $��30 �6     � ColumnDefinitions 5a      �� 5b      $��14 �6#   �� 5c      $	��200 �6#   �� 5d      $��10 �6#   �� 5e      �� 5f      $��10 �6#   .+�5h      �� -   5         ��Name$
 List��5l      $��1��5j      $��3��5k      #��[ 5m      
�������$��Disabled=�5o      $��10q�5p      ��5i      �� *EmployeeView+  �� IsAsync  . ��5q      �� 5r      .R�5s      �� $��2q�6!   
�������$	��140��6H   $	��120��6U   #���  6a   ._�5t      �� .+�5u   "   �� $��2q�5v   !   $��80��5w   !   $��90��5x   !   
������$��2��5z   !   ��5{   &   �� 5|   *   ! j� Stretch$! Uniform=�6W   " �� ImageSource" 65   �� *	ImagePath+6W   5~   #   �� 5   "   # �� Orientation$# Vertical=�6-   .+�5�   &   �� $��Center=�6K   ��60   �� *	Firstname+6K   �� 5�   &   $��Center=�6J   ��60   �� *
Lastname+6J   �� 5�   &   $��Center=�6L   ��60   �� *
Patronymic+6L   5�   #   5�      
 5�      :� 5�   "   $ 
MouseEnter��6/   .[�5�   &   �� .��5�   *   �� .��5�   .   �� $' !Background.GradientStops[2].Color�6=   $ WhiteX�6{   $ 0:0:0.3D�6�   �� 5�   .   $' !Background.GradientStops[1].Color�6=   $ WhiteX�6{   $ 0:0:0.3D�6�   �� 5�   .   $' !Background.GradientStops[0].Color�6=   $ BlackX�6{   $ 0:0:0.3D�6�   �� 5�   .   $' !Background.GradientStops[3].Color�6=   $ BlackX�6{   $ 0:0:0.3D�6�   5�   +   5�   '   5�   #   :� 5�   "   $ 
MouseLeave��6/   .[�5�   &   �� .��5�   *   �� .��5�   .   �� $' !Background.GradientStops[2].Color�6=   $ 	LightGrayX�6{   �� 5�   .   $' !Background.GradientStops[1].Color�6=   $ 	LightGrayX�6{   �� 5�   .   $' !Background.GradientStops[0].Color�6=   $
 GrayX�6{   �� 5�   .   $' !Background.GradientStops[3].Color�6=   $
 GrayX�6{   5�   +   5�   '   5�   #   5�      5�      ��5�      �� 5�      .R�5�      � 5�      5�      �� 5�      $��2��6   $��0��6+   $��3��68   $��Center=�6I   $��Stretch=�6f   $��4��6�   �� 5�      $��1��6   $��1��6(   $��0,10,0,0q�68   ��5�      �� 5�      " ��6   $ �� Triggers$ 5�      �� 5�      % �� Binding% 6*   �� & �� ElementName$
& List��' �� Path$' SelectedItem�( �� Value( 6b   Z� .a�5�   "   �� ) �� Property) � y�* �� Value$* 	Collapsed=�6?   5�      5�      .��5�      � -   5        + �Name$+ empData��5�   e   $��0,0,10,0q�6S    6   �� $
& List��$' SelectedItem� 5�      �� 5�      $��20 �6(   �� 5�      $
��auto �6(   �� 5�      $
��auto �6(   �� 5�      .+�5�      �� $#��Фото сотрудника��6    $��12(�67   $��0,0,0,-3q�6E   �� 5�      , �� Padding$, 7q�6   $��5q�6)   
�������
�������$��1��6g   ._�5�      �� ��6    �� *	ImagePath+5�      �� 5�      $��2��6   $, 7q�6*   ���	#99FFFFFF._�5�      �� .+�5�      �� #��[ 5�   !   $��20��5�   !   $��20��6-   $��Right=�5�   !   
���������5�   !   �� *ChooseImage+��5�   !   �� $
& List��$' SelectedItem� 5�   !   �� $& 
mainWindow��$' DataContext�5�   !   �� 5�      $��Фамилия��6(   �� 5�      ��6&   �� *
Lastname+�� 5�      $��Имя��6(   �� 5�      ��6&   �� *	Firstname+�� 5�      $��Отчество��6(   �� 5�      ��6&   �� *
Patronymic+�� 5�      $��Телефон��6(   �� 5�      ��6&   �� *Phone+�� 5�      $��День рождения��6(   �� 5�      ��6&   �� *
Birthday+- �� 	Converter#- [  �� 5�      $��Стаж��6(   �� 5�      ��6&   �� *	WorkAge+� 5�      $��5q�6#    6.   �� $' Position� 5�   "   �� 5�   &   $
��auto �64   �� 5�   &   $
��auto �64   �� 5�   &   $
��auto �64   �� 5�   &   $
��auto �64   .+�5�   "   �� $, 7q�6)   $��10q�65   
�������$��3q�6Y   ._�5�   &   �� $��80��6I   ��6,   �� *	ImagePath+6I   5�   #   �� 5�   "   $��1��6,   ��69   �� *	StageName+�� 5�   "   $��2��6-   $# 
Horizontal=�6:   .+�5�   &   �� $��Оклад: ��60   $��0,0,10,0q�6?   �� 5�   &   ��60   �� *Salary+5�   #   5�      �� 5�      #��[ 6%   $��Удалить��5�   %   $��Center=�5�   %    5�   I   �� $& 
mainWindow��$' DataContext���5�   %   �� *Remove+��5�   %   �� $
& List��$' SelectedItem�5�      5�      5�      5�      ]� 5�      $��3��6   .+�5�      �� -   5        . ��Name$. Header��5�      $	��Top=�5�      $��0,3,0,3q�5�      $)��#Список сотрудников��5�      $��Consolas)�5�      $��Center=�5�      $	��Top=�5�      $��18(�5�      $
��Bold"�5�      
������ 
������ 5�      �� 5�      $��Bottom=�5�       	 
MirrorEdge#��[	 5�      ��5�      �� $& Header��$' ActualWidth�/ J� OpacityMask/ 5�      �� 5�      0 �� 
StartPoint$0 0.5,0&�6.   1 �� EndPoint$1 0.5,1&�6A   ��5�   "   � 2 � Offset$	2 0.0Q�6/   3 � Color$3 	#66000000��6<   � 5   "   $	2 1.0Q�6/   $3 	#00000000��6<   5     5     5     5     5     5	     
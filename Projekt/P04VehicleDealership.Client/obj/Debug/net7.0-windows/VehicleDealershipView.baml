   M S B A M L   `   `   `  ����V  RP04VehicleDealership.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:P04VehicleDealership.ClientP04VehicleDealership.Client  5      7    1P04VehicleDealership.Client.VehicleDealershipView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      ;local)clr-namespace:P04VehicleDealership.Client     5        � Title$  ShopProductsWindow��5      $	��471��6    $	��900��6-    � 	Resources 5
         boolToVisConv  mainButtonStyle �� 
TargetType �� Property �� Value  ButtonBackground  ButtonForeground  ButtonBorder  mainLabelStyle��%  &	        &	      &	 Z    �� 5   
   6@   �� 5   
   " ��6(   .�5      ��  � ��$ 5q�6'   �� 5       � ��$ 10q�6(   �� 5       � ��$
 Bold"�6+   �� 5       � ��# �  6+   �� 5       � ��# �  6+   �� 5       � ��# �  6,   �� 5       � ��$ 1q�60   �� 5       �@�Cursor$
 Hand��6'   5      �� 5   
   " ��6'   .�5      ��  � ��$ 18(�6)   �� 5       � ��$ Center=�64   �� 5       � ��
 �   �6+   5      5      .��5      ]� $��0��6   $��0��6      ThemeBackgroundColor#���  6-   .+�5    
   �� $	��350��68   $	��Top=�6E   #���  6Z   ��6   �� *PageVehicles+��5!      �� 5"      .R�5#      �� 
�������$��1q�60    �� CornerRadius$ 4��6D    �� Padding$ 10q�6U   $��5q�6b   ._�5$      � $	��300��6    � RowDefinitions 5%      �� 5&   "   $
��Auto �60   6@   �� 5'   "   $
��Auto �60   6@   �� 5(   "   $
��Auto �60   6@   �� 5)   "   $
��Auto �60   6@   .+�5-      �� $��0��6)    �� Orientation$ 
Horizontal=�66   .+�5/   "   �� $
��Bold"�6?   $��0 0 10 0q�6Q     LabelForeground#���  6c   ��6(   �� *Id+6�   �� 50   "   $��16(�6B   $
��Bold"�6P     ModelForeground#���  6b   ��6(   �� *Model+6�   �� 51   "   $��16(�6A   $
��Bold"�6O    	 FuelForeground#��� 	 6a   ��6(   �� *Fuel+6�   52      �� 55      $��2��6)   $ 
Horizontal=�66   .+�56   "   �� 
��� d �$��0 0 10 0q�6C   58   #   59      �� 5:      $��3��6%   #��[ 5<       
 EditVehicle#��� 
 6H   ��5;      �� * DataContext.ShowDetailsCommand+	 �� RelativeSource	 �� 
 �� AncestorType
 ListView��5<      �� ��5=   "   �� 5>   &    �� 
TargetType" ��66   .R�5?   *   ��  ��Name$ border��61   
�������$��1q�6T   $ 4��6h   #��z��6y   ._�5@   .   �� $��Center=�6?   $��Center=�6\   5A   +    �� Triggers 5B   *   P� 5C   .    P� Property �@J�IsMouseOver P� Value$
 True��6M   . �5D   2   ��  �� 
TargetName$ border��69    � ��
 ��·�6c   �� 5E   2    � ��
 �����6O   5F   /   5H   '   5J      5K      5L      5N      5P      �� 5Q   
   $
��Left=�6     
NewVehicle#���  6'   #��[ 6m   $	��130��6�   $��50��6�   ��6N   �� *
NewCommand+6�   �� 5S   
   $
��Left=�6     PrevPage#���  6'   #��[ 6t   $	��130��6�   $��50��6�   ��6L   �� *PreviousPageCommand+6�   �� 5U   
   $
��Left=�6     NextPage#���  6'   #��[ 6p   $	��130��6�   $��50��6�   ��6L   �� *NextPageCommand+6�   �� 5W   
   $
��Left=�6     
PageNumber#���  6&   $
��Bold"�6N   $��Center=�6`   #���  6{   6�   �� 5X   
   $
��Left=�6   $
��Bold"�6G   #���  6Y   $��Center=�6�   ��6&   �� *CurrentPage+6�   �� 5Y   
   $
��Left=�6   $	�� / ��6&   $
��Bold"�65   $��Center=�6G   #���  6c   6�   �� 5Z   
   $
��Left=�6   $��Center=�6B   $
��Bold"�6]   #���  6o   ��6&   �� *	MaxPage+6�   �� 5[   
   $
��Left=�6   $�� ��6&   $��Center=�62   #���  6M   6   5]      5_      
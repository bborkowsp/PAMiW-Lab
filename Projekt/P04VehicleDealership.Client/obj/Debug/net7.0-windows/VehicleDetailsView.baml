   M S B A M L   `   `   `  ����V  RP04VehicleDealership.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:P04VehicleDealership.ClientP04VehicleDealership.Client  5   	   4    .P04VehicleDealership.Client.VehicleDetailsView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:P04VehicleDealership.Client     5   	   -   5          � Title$  ProductDetailsView��5   	   $	��200��6$   $	��300��61    � 	Resources 5
         boolToVisConv  mainButtonStyle �� 
TargetType �� Property �� Value  ButtonBackground  ButtonForeground  ButtonBorder  mainLabelStyle��%  &	        &	      &	 Z    �� 5   
   6@   �� 5   
   " ��6(   .�5      ��  � ��$ 5q�6'   �� 5       � ��$ 10q�6(   �� 5       � ��$
 Bold"�6+   �� 5       � ��# �  6+   �� 5       � ��# �  6+   �� 5       � ��# �  6,   �� 5       �@�Cursor$
 Hand��6'   �� 5       � ��$ 1q�60   5      �� 5   
   " ��6'   .�5      ��  � ��$ 18(�6)   �� 5       � ��$ Center=�64   �� 5       � ��
 �   �6+   5      5      .��5      ��   ThemeBackgroundColor#���  6   .+�5   
   � $��10q�68   #���  6D    � DataContext 6   �� *SelectedVehicle+ � RowDefinitions 5      �� 5       $
��Auto �6    �� 5!      $
��Auto �6    �� 5"      $
��Auto �6    �� 5#      $
��Auto �6    �� 5$      $
��Auto �6    �� 5%      $
��Auto �6    �� 5&      $
��Auto �6     � ColumnDefinitions 5)      �� 5*      $
��Auto �6#   �� 5+      $��* �6#   .+�5.      �� $��Model:��6   $��0��6&   $��0��63     LabelForeground#���  6C   �� 5/      $��0��6-   $��1��6:   $��	20,0,0,18q�6J   $��2��6]   ��6   �� *Model+6]   �� 51        Fuel#���  6   $��1��66   $��0��6C   #���  6S   �� 52      $��1��6,   $��1��69   $��	20,0,0,16q�6I   $��6��6\   ��6   �� *Fuel+6\   �� 56      $	��ID:��6   $��6��6#   $��0��60   #���  6@   �� 57      $��6��6,   $��1��69   $��20,0,0,0q�6I   #���  6[   ��6   �� *Id+6[   �� 58      $��1��6,   $��1��69   $��20,0,0,0q�6I   ��6   �� *Fuel+6I   59      �� 5:   
   .+�5;      �� $��	0 10 0 10q�6    	 SaveVehicle#��� 	 5=      #��[ 64   $	��100��6]   ��5<   	   �� *SaveCommand+��5>      �� 5?       �� 
TargetType" ��6&   .R�5@      �� 	 ��Name$	 border��6!   
�������$��1q�6D   
 �� CornerRadius$
 4��6X   #��z��6i   ._�5A      �� $��Center=�6/   $��Center=�6L   5B       �� Triggers 5C      P� 5D       P� Property �@J�IsMouseOver P� Value$
 True��6=   . �5E   "   ��  �� 
TargetName$ border��6)    � ��
 ��·�6S   �� 5F   "    � ��
 �����6?   5G      5I      5K      �� 5L       
 DeleteVehicle#��� 
 5N      #��[ 66   $	��100��6_   ��5M   	   �� *DeleteCommand+��5O      �� 5P      " ��6&   .R�5Q      �� $	 border��6!   
�������$��1q�6D   $
 4��6X   #��z��6i   ._�5R      �� $��Center=�6/   $��Center=�6L   5S       5T      P� 5U       �@J�IsMouseOver$
 True��6=   . �5V   "   �� $ border��6)    � ��
 ��·�6S   �� 5W   "    � ��
 �����6?   5X      5Z      5]      5^      5_      5f      
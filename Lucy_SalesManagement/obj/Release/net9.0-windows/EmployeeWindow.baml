   M S B A M L   `   `   `  ����   Lucy_SalesManagement)    #Lucy_SalesManagement.EmployeeWindow   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  LucySale Dashboard�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ 	CanResize=�$	��900��$	��600�����#F5F7FA � 	Resources    	NavButton �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius	 �� Triggers
 P� Property P� Value  
TileButton J� SnapsToDevicePixels��%�  &	        &	 A    �� " ��.���  � ��
 ���� ��  � ��
 �������  � ��$	 8,4q���  � ��$ SemiBold"���  �@�Cursor$
 Hand����  � ��$ 0q���  � �� �� " ��.R��� #��z��$ 4��._��� $��Center=�$��Center=�	 P� 
 �@J�IsMouseOver$
 True��. ���  � �� �	#44FFFFFF�� " ��.���  � ��
 �������  � �� �#DDD��  � ��$ 1q���  � ��$ 16q���  �@�Cursor$
 Hand����  � �� �� " ��.R��� #��z��#��z��#��z��$ 8��$
 True��._��� $��Center=�$��Center=�.+��� $��Center=�	 P� 
 �@J�IsMouseOver$
 True��. ���  � �� �	#FFF0F0F0.��]� .+�� $	��Top=�$��60�����#2C3E50 � ColumnDefinitions �� $��* ��� $
��Auto �.+��� $��LucySale��$��Center=�$��24,0,0,0q�$��24(�$
��Bold"�
��������� -   $��1��$��Logout��#��[  $��0,0,24,0q�$��Center=��� $	��Top=�
������� �� Padding$ 16,12q����#EEE$��0,0,0,1q�._��� -    ��Name$ 
txtWelcome��$��16(����#333� $��24q�$��Center=�$��Center=� J� RenderTransformOrigin$ 0.519,-0.385&� �� $
��Auto ��� $
��Auto � � RowDefinitions �� $
��Auto ��� $
��Auto �.+��� -   $��0��$��0��#��[ $	��200��$��60��$��16(�$��8q�.��Manage Customers�� -   $��0��$��1��#��[ $	��200��$��60��$��16(�$��8q�.��Manage Products�� -   $��1��$��0��#��[ $	��200��$��60��$��16(�$��8q�.��Create & View Orders�� -   $��1��$��1��#��[ $	��200��$��60��$��16(�$��8q�.��	Reports
   M S B A M L   `   `   `  ����   Lucy_SalesManagement-    'Lucy_SalesManagement.ManageReportWindow   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Reports�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ 	CanResize=�$	��900��$	��600�����#F5F7FA � 	Resources 3  -System.Windows.Media.Effects.DropShadowEffect   ButtonNormalShadow   Color   
BlurRadius   ShadowDepth   Opacity  ButtonHoverShadow  	NavButton �� 
TargetType	 �� Property
 �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value  
InputStyle ��Name  PrimaryButton �� BasedOn ��Name J� Effect �� 
TargetName  CenteredCell  RightAlignedCell��%H  &	        &	 /     &	 _     &	 �    &	 �    7  7   7  7   &	 g    &	 �    7    $ 	#44000000��$ 8Q�$ 2Q�$	 0.5Q�  $ 	#66000000��$ 16Q�$ 4Q�$	 0.8Q��� " ��.��� 	 � ��

 ���� �� 	 � ��

 ������� 	 � ��$	
 8,4q��� 	 � ��$
 SemiBold"��� 	 �@�Cursor$

 Hand���� 	 � ��$
 0q��� 	 � ��
 �� " ��.R��� #��z��$ 4��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ��� 	 � ��
 �	#44FFFFFF�� " ��.��� 	 � ��$
 0,4,0,4q��� 	 � ��$
 24���� 	 � ��$
 14(��� 	 � ��$
 4q��� 	 � ��
 �#CCC�� 	 � ��

 ������� 	 � ��$
 1q��� 	 � ��
 �� " ��.R��� #��z��#��z��#��z��$ 4��._��� $ PART_ContentHost��$��0q��� " ��8   .��� 	 � ��
 �#2C3E50�� 	 � ��

 ������� 	 � ��$
 14(��� 	 � ��$	
 8,4q��� 	 � ��$
 32���� 	 � ��$
 4q��� 	 �@J�Effect8
  �� 	 � ��
 �� " ��.R��� $ border��#��z��$ 4��# z ._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ��� $ border��8
  	 �@J�EffectP�  � ��$
 True��. ��� $ border��8
  	 �@J�Effect�� " ��.��� 	 � ��$
 Center=��� 	 � ��$
 Center=��� " ��8   .��� 	 � ��$
 Right=��� 	 � ��$
 0,0,6,0q�.��]� .+�� $	��Top=�$��60�����#2C3E50 � ColumnDefinitions �� $��* ��� $
��Auto �.+��� $��LucySale��$��Center=�$��24,0,0,0q�$��24(�$
��Bold"�
��������� -   $��1��$��Logout��#��[ $��0,0,24,0q�$��Center=��� $	��Top=�
������� �� Padding$ 16,12q����#EEE$��0,0,0,1q�._��� $��Reports: Orders by Period��$��16(����#333� $��24q�$	��545�� � RowDefinitions �� $
��Auto ��� $��* �.+���  �� Orientation$ 
Horizontal=�$��0��$��Center=�$��0,0,0,8q�.+��� $��From:��$��Center=�$��0,0,4,0q�$��24��$��48��(  "System.Windows.Controls.DatePicker  -     Name$ dpStart��$��0,0,16,0q�$	��127���� $	��To:��$��Center=�$��0,0,4,0q�$��26��$��23��  -   $ dpEnd��$��0,0,16,0q�$	��131���� -   $��Generate Report��#��[  J� RenderTransformOrigin$ 1.515,0.998&�$	��132��&   System.Windows.Controls.DataGrid  -     Name$ dgReport��   AutoGenerateColumns$ False��   CanUserAddRows$ False��   HeadersVisibility$ Column=�   SelectionMode$ Single=�    	RowHeight$  28Q�!   AlternatingRowBackground! �#F9F9F9"   RowBackground
" �����#   GridLinesVisibility$
# None=�$��Segoe UI)�$��13(�$��0,45,0,3q�$��2��$
��Left=�$	��542��$   Columns$ 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn%   Header$% Order #��&   Width5  /System.Windows.Controls.DataGridLengthConverter$& 70 1  +System.Windows.Controls.DataGridBoundColumn'   ElementStyle#' [ (   Binding( �� *	OrderID+  $
% Date��$	& 110 #' [ ( �� *	OrderDate+) �� StringFormat$) {0:dd/MM/yyyy}��  $% Customer��$	& 100 #' [ ( �� *
CustomerID+  $% Employee��$	& 100 #' [ ( �� *
EmployeeID+  $% 	Total ($)��$	& 100 #' [ ( �� *TotalAmount+$) N2��
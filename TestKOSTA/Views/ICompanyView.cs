using System.Windows.Forms;
using TestKOSTA.Repository;

namespace TestKOSTA.Views
{
	public interface ICompanyView
	{
		void ShowTreeStructure(TreeNode root);
		void ShowTreeStructure(TreeNode root,TreeNode selectedNode);
		void ShowDepartmentInfo(Department dept);
		void ShowEmployeeInfo(Empoyee employee);
	}
}

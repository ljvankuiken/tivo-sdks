//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tivo.Has.AddInSideAdapters
{
    
    public class ApplicationEndedEventArgsAddInAdapter
    {
        internal static Tivo.Has.ApplicationEndedEventArgs ContractToViewAdapter(Tivo.Has.Contracts.IApplicationEndedEventArgs contract)
        {
            if (((System.Runtime.Remoting.RemotingServices.IsObjectOutOfAppDomain(contract) != true) 
                        && contract.GetType().Equals(typeof(ApplicationEndedEventArgsViewToContractAddInAdapter))))
            {
                return ((ApplicationEndedEventArgsViewToContractAddInAdapter)(contract)).GetSourceView();
            }
            else
            {
                return new ApplicationEndedEventArgsContractToViewAddInAdapter(contract);
            }
        }
        internal static Tivo.Has.Contracts.IApplicationEndedEventArgs ViewToContractAdapter(Tivo.Has.ApplicationEndedEventArgs view)
        {
            if (view.GetType().Equals(typeof(ApplicationEndedEventArgsContractToViewAddInAdapter)))
            {
                return ((ApplicationEndedEventArgsContractToViewAddInAdapter)(view)).GetSourceContract();
            }
            else
            {
                return new ApplicationEndedEventArgsViewToContractAddInAdapter(view);
            }
        }
    }
}


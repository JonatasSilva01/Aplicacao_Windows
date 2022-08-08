using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsProjeto
{
    public class MDISigleton
    {
        private MDISigleton() { }

        private static MDIParent instanceMdiParentPrincipal;

        public static MDIParent criarInstaciaMdiParent()
        {
            if(instanceMdiParentPrincipal == null)
            {
                instanceMdiParentPrincipal = new MDIParent();
                return instanceMdiParentPrincipal;
            }
            return instanceMdiParentPrincipal;
        }
    }
}

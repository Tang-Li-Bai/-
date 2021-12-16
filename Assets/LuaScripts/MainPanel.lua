BasePanel:subClass("MainPanel")

function MainPanel:Init(name)
    self.base.Init(self,name)
    if self.isInitEvent == true then
        self:GetControl("btnBegin","Button").onClick:AddListener(
            function ()
                GamePanel:ShowMe("GamePanel")
            end
        )
    end
end
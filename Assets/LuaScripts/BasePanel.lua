Object:subClass("BasePanel")
--预制体
BasePanel.panelObj = nil
--所有的组件
BasePanel.controls = {}
--是否初始化成功
BasePanel.isInitEvent = true

function BasePanel:Init(name)
    if self.panelObj == nil and UnityFunction.ABManager:LoadRes("panel",name,GameObject) ~= nil then
        --实例化面板
        self.panelObj = GameObject.Instantiate(UnityFunction.ABManager:LoadRes("panel",name,GameObject),GameObject.Find("Canvas").transform,false)
        
        print("打开"..name.."面板成功")
        --获取所有的UI组件
        local allControls = self.panelObj:GetComponentsInChildren(UnityEngine.EventSystems.UIBehaviour)
        

        for i = 1,allControls.Length do
            local controlName = allControls[i].name

            --Lua只想到通过名字来找，所以需要命名规范
            --可以增加组件类型
            if string.find(controlName,"btn")~= nil  or
            string.find(controlName,"tog")~= nil or
            string.find(controlName,"img")~= nil or
            string.find(controlName,"sv")~= nil or
            string.find(controlName,"txt") ~= nil then
                
                local typeName = allControls[i]:GetType().Name
                print("获得组件"..controlName.."类型为"..typeName)
                --最终的存储形式
                --{control = {Image = 控件},Button = {控件}}
                if self.controls[controlName] ~= nil then
                    self.controls[controlName][typeName] = allControls[i]
                else
                    self.controls[allControls[i].name] = {[typeName] = allControls[i]}
                end

            end
            print("面板"..name.."获得组件成功")
        end
    else
        self.isInitEvent = false
    end

end

--获得组件
function BasePanel:GetControl(name,typeName)
    if self.controls[name] ~= nil then
        local sameNameControls = self.controls[name]
        if sameNameControls[typeName] ~= nil then
            return sameNameControls[typeName]
        end
    end
end

function BasePanel:ShowMe(name)
    self:Init(name)
    if self.panelObj ~= nil then
        self.panelObj:SetActive(true)
    end
end

function BasePanel:HideMe()
    if self.panelObj ~= nil then
        self.panelObj:SetActive(false)
    end
end
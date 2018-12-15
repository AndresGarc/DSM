using BaseDatosGenNHibernate.CAD.BaseDatos;
using BaseDatosGenNHibernate.CEN.BaseDatos;
using BaseDatosGenNHibernate.EN.BaseDatos;
using SuperPet.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperPet.Controllers
{
    public class SliderController : BasicController
    {
        // GET: Slider
        public ActionResult Index()
        {
            //EJEMPLO CON EL CEN
            SessionInitialize();
            SliderCAD sliCAD = new SliderCAD(session);
            SliderCEN sliCEN = new SliderCEN(sliCAD);
            IList<SliderEN> listSliEN = sliCEN.MuestraSliders(0,-1);
            IEnumerable<Slider> lista = new AssemblerSlider().ConvertListENToModel(listSliEN).ToList();
            SessionClose();
            return View(lista);
        }
        // GET: Slider/Edit/
        public ActionResult Edit(int id)
        {
            SessionInitialize();
            SliderEN sliEN = new SliderCAD(session).MuestraSliderPorOID(id);
            Slider sli = new AssemblerSlider().ConvertENToModelUI(sliEN);
            return View(sli);
        }

        // POST: Slider/Edit/5
        [HttpPost]
        public ActionResult Edit(Slider sli, HttpPostedFileBase file1, HttpPostedFileBase file2, HttpPostedFileBase file3, HttpPostedFileBase file4)
        {
            string fileName = "", path = "";
            // Verify that the user selected a file
            if (file1 != null && file1.ContentLength > 0)
            {
                // extract only the fielname
                fileName = Path.GetFileName(file1.FileName);
                // store the file inside ~/App_Data/uploads folder
                path = Path.Combine(Server.MapPath("~/images/uploads/slider"), fileName);
                //string pathDef = path.Replace(@"\\", @"\");
                file1.SaveAs(path);


                try
                {
                    fileName = "/images/uploads/slider/" + fileName;
                    //SliderCEN cen = new SliderCEN();
                    //cen.CambiarImagen(sli.Id, 0, fileName);

                    SessionInitialize();
                    SliderCAD sliCAD = new SliderCAD();
                    SliderCEN sliCEN = new SliderCEN(sliCAD);
                    sliCEN.CambiarImagen(sli.Id, 0, fileName);
                    SessionClose();
                }
                catch
                {
                    return View();
                }
            }

            if (file2 != null && file2.ContentLength > 0)
            {
                // extract only the fielname
                fileName = Path.GetFileName(file2.FileName);
                // store the file inside ~/App_Data/uploads folder
                path = Path.Combine(Server.MapPath("~/images/uploads/slider"), fileName);
                //string pathDef = path.Replace(@"\\", @"\");
                file2.SaveAs(path);


                try
                {
                    fileName = "/images/uploads/slider/" + fileName;
                    //SliderCEN cen = new SliderCEN();
                    //cen.CambiarImagen(sli.Id, 0, fileName);

                    SessionInitialize();
                    SliderCAD sliCAD = new SliderCAD();
                    SliderCEN sliCEN = new SliderCEN(sliCAD);
                    sliCEN.CambiarImagen(sli.Id, 1, fileName);
                    SessionClose();
                }
                catch
                {
                    return View();
                }
            }

            if (file3 != null && file3.ContentLength > 0)
            {
                // extract only the fielname
                fileName = Path.GetFileName(file3.FileName);
                // store the file inside ~/App_Data/uploads folder
                path = Path.Combine(Server.MapPath("~/images/uploads/slider"), fileName);
                //string pathDef = path.Replace(@"\\", @"\");
                file3.SaveAs(path);


                try
                {
                    fileName = "/images/uploads/slider/" + fileName;
                    //SliderCEN cen = new SliderCEN();
                    //cen.CambiarImagen(sli.Id, 0, fileName);

                    SessionInitialize();
                    SliderCAD sliCAD = new SliderCAD();
                    SliderCEN sliCEN = new SliderCEN(sliCAD);
                    sliCEN.CambiarImagen(sli.Id, 2, fileName);
                    SessionClose();
                }
                catch
                {
                    return View();
                }
            }
            if (file4 != null && file4.ContentLength > 0)
            {
                // extract only the fielname
                fileName = Path.GetFileName(file4.FileName);
                // store the file inside ~/App_Data/uploads folder
                path = Path.Combine(Server.MapPath("~/images/uploads/slider"), fileName);
                //string pathDef = path.Replace(@"\\", @"\");
                file4.SaveAs(path);


                try
                {
                    fileName = "/images/uploads/slider/" + fileName;
                    //SliderCEN cen = new SliderCEN();
                    //cen.CambiarImagen(sli.Id, 0, fileName);

                    SessionInitialize();
                    SliderCAD sliCAD = new SliderCAD();
                    SliderCEN sliCEN = new SliderCEN(sliCAD);
                    sliCEN.CambiarImagen(sli.Id, 3, fileName);
                    SessionClose();
                }
                catch
                {
                    return View();
                }
            }

            return RedirectToAction("Index");
        }

    }
}
